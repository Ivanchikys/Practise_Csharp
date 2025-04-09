using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using TeacherJournal.Commands;
using TeacherJournal.Models;
using TeacherJournal.Services;

namespace TeacherJournal.ViewModels;

public class JournalViewModel : INotifyPropertyChanged, IDisposable
{
    private readonly IChatService _chatService;

    private readonly HomeworkNotificationService _homeworkNotificationService;
    private string _chatMessage;
    private readonly Dictionary<string, ObservableCollection<StudentGradeItem>> _courseCache;
    private UserModel _currentUser;
    private string _homeworkNotification;
    private string _homeworkText;

    private bool _isLoading;
    private string _lastNotification;
    private string _lastShownHomeworkNotification;

    private DispatcherTimer _notificationTimer;
    private CourseModel _selectedCourse;
    private StudentGradeItem _selectedGrade;

    public JournalViewModel(UserModel currentUser)
    {
        CurrentUser = currentUser;
        StudentGrades = new ObservableCollection<StudentGradeItem>();
        Courses = new ObservableCollection<CourseModel>();
        _courseCache = new Dictionary<string, ObservableCollection<StudentGradeItem>>();

        AddGradeCommand = new RelayCommand(_ => AddGrade());
        EditGradeCommand = new RelayCommand(_ => EditGrade(), _ => SelectedGrade != null);
        DeleteGradeCommand = new RelayCommand(_ => DeleteGrade(), _ => SelectedGrade != null);
        SendHomeworkCommand = new RelayCommand(SendHomework, CanSendHomework);

        Courses.Add(new CourseModel { CourseName = "КПиЯП" });
        Courses.Add(new CourseModel { CourseName = "Практика" });
        Courses.Add(new CourseModel { CourseName = "ТПО" });

        SelectedCourse = Courses.Count > 0 ? Courses[0] : null;
        _homeworkNotificationService = new HomeworkNotificationService(new MemoryMappedFileService());

        _chatService = new NamedPipeChatService();
        _chatService.StartListening();

        OpenChatCommand = new RelayCommand(OpenChatWindow);

        InitializeNotificationTimer();
    }

    public ObservableCollection<StudentGradeItem> StudentGrades { get; set; }
    public ObservableCollection<CourseModel> Courses { get; set; }

    public ICommand SendChatCommand { get; }
    public ICommand AddGradeCommand { get; }
    public ICommand EditGradeCommand { get; }
    public ICommand DeleteGradeCommand { get; }
    public ICommand SendHomeworkCommand { get; }
    public ICommand OpenChatCommand { get; }

    public string ChatMessage
    {
        get => _chatMessage;
        set
        {
            if (_chatMessage != value)
            {
                _chatMessage = value;
                OnPropertyChanged();
            }
        }
    }

    public string LastNotification
    {
        get => _lastNotification;
        set
        {
            if (_lastNotification != value)
            {
                _lastNotification = value;
                OnPropertyChanged();
            }
        }
    }

    public StudentGradeItem SelectedGrade
    {
        get => _selectedGrade;
        set
        {
            if (_selectedGrade != value)
            {
                _selectedGrade = value;
                OnPropertyChanged();
            }
        }
    }

    public CourseModel SelectedCourse
    {
        get => _selectedCourse;
        set
        {
            if (_selectedCourse != value)
            {
                _selectedCourse = value;
                OnPropertyChanged();
                _ = LoadDataAsync();
            }
        }
    }

    public bool IsLoading
    {
        get => _isLoading;
        set
        {
            if (_isLoading != value)
            {
                _isLoading = value;
                OnPropertyChanged();
            }
        }
    }

    public bool IsTeacher { get; private set; }

    public bool IsStudent => !IsTeacher;

    public UserModel CurrentUser
    {
        get => _currentUser;
        set
        {
            if (_currentUser != value)
            {
                _currentUser = value;
                OnPropertyChanged();
                IsTeacher = value?.Role == "Teacher";
                OnPropertyChanged(nameof(IsTeacher));
                OnPropertyChanged(nameof(IsStudent));
            }
        }
    }

    public string HomeworkText
    {
        get => _homeworkText;
        set
        {
            if (_homeworkText != value)
            {
                _homeworkText = value;
                OnPropertyChanged();
            }
        }
    }

    public string HomeworkNotification
    {
        get => _homeworkNotification;
        set
        {
            if (_homeworkNotification != value)
            {
                _homeworkNotification = value;
                OnPropertyChanged();
            }
        }
    }

    public void Dispose()
    {
        Cleanup();
        GC.SuppressFinalize(this);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OpenChatWindow(object parameter)
    {
        var chatViewModel = new ChatViewModel(CurrentUser, _chatService);
        var chatWindow = new ChatWindow(chatViewModel)
        {
            Owner = Application.Current.MainWindow
        };
        chatWindow.Show();
    }

    public async Task LoadDataAsync()
    {
        if (SelectedCourse == null)
        {
            StudentGrades.Clear();
            IsLoading = false;
            return;
        }

        IsLoading = true;
        try
        {
            var allGrades = await JournalService.LoadStudentGradesAsync(SelectedCourse);
            
            var studentGroups = allGrades.GroupBy(g => g.FullName);
            
            var averageByFullName = new Dictionary<string, double>();
            foreach (var group in studentGroups)
            {
                var grades = group.Select(g => double.TryParse(g.Grade, out var grade) ? grade : 0).ToList();
                averageByFullName[group.Key] = grades.Any() ? grades.Average() : 0;
            }
            
            StudentGrades.Clear();
            
            foreach (var grade in allGrades)
            {
                var student = new StudentGradeItem
                {
                    FullName = grade.FullName,
                    Grade = grade.Grade,
                    Comment = grade.Comment,
                    IsPresent = grade.IsPresent,
                    CourseName = SelectedCourse.CourseName,
                    Average = averageByFullName[grade.FullName]
                };
                StudentGrades.Add(student);
            }
            
            _courseCache[SelectedCourse.CourseName] = new ObservableCollection<StudentGradeItem>(StudentGrades);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            StudentGrades.Clear();
        }
        finally
        {
            IsLoading = false;
        }
    }

    private void AddGrade()
    {
        if (SelectedCourse == null)
        {
            MessageBox.Show("Сначала выберите курс.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            return;
        }

        var newStudentGrade = new StudentGradeItem
        {
            FullName = "Новый студент",
            Grade = "Н/А",
            Comment = "",
            IsPresent = true,
            CourseName = SelectedCourse.CourseName
        };

        StudentGrades.Add(newStudentGrade);

        if (_courseCache.TryGetValue(SelectedCourse.CourseName, out var cachedList))
            cachedList.Add(newStudentGrade);
        else
            _courseCache[SelectedCourse.CourseName] = new ObservableCollection<StudentGradeItem> { newStudentGrade };

        SelectedGrade = newStudentGrade;

        SaveChanges();
    }

    public void EditGrade()
    {
        if (SelectedGrade != null)
        {
            var editWindow = new EditGradeWindow(SelectedGrade);
            if (editWindow.ShowDialog() == true)
            {

                string oldFullName = SelectedGrade.FullName;

                SelectedGrade.FullName = editWindow.EditedStudent.FullName;
                SelectedGrade.Grade = editWindow.EditedStudent.Grade;
                SelectedGrade.Comment = editWindow.EditedStudent.Comment;
                SelectedGrade.IsPresent = editWindow.EditedStudent.IsPresent;

                if (oldFullName != SelectedGrade.FullName)
                {
                    RecalculateAverageForStudent(oldFullName);
                    RecalculateAverageForStudent(SelectedGrade.FullName);
                }
                else
                {
                    RecalculateAverageForStudent(SelectedGrade.FullName);
                }
                
                OnPropertyChanged(nameof(SelectedGrade));
                SaveChanges();
            }
        }
    }

    private void RecalculateAverageForStudent(string fullName)
    {
        var studentGrades = StudentGrades.Where(s => s.FullName == fullName).ToList();
        var grades = studentGrades.Select(g => double.TryParse(g.Grade, out var grade) ? grade : 0).ToList();
        double newAverage = grades.Any() ? grades.Average() : 0;

        foreach (var student in studentGrades)
        {
            student.Average = newAverage;
            OnPropertyChanged(nameof(student.Average));
        }
    }
    private void DeleteGrade()
    {
        if (SelectedGrade != null)
            if (MessageBox.Show($"Удалить запись для студента '{SelectedGrade.FullName}'?", "Подтверждение удаления",
                    MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                var gradeToRemove = SelectedGrade;
                StudentGrades.Remove(gradeToRemove);
                if (SelectedCourse != null && _courseCache.TryGetValue(SelectedCourse.CourseName, out var cachedList))
                    cachedList.Remove(gradeToRemove);

                SelectedGrade = null;
                SaveChanges();
            }
    }

    private void SaveChanges()
    {
        if (SelectedCourse == null) return;
        
        try
        {
            var journalData = DataStorageService.LoadJournalData() ??
                              new JournalData { Grades = Array.Empty<StudentGradeItem>() };

            var otherGrades = journalData.Grades?.Where(g => g.CourseName != SelectedCourse.CourseName).ToList()
                              ?? new List<StudentGradeItem>();
            otherGrades.AddRange(StudentGrades);

            journalData.Grades = otherGrades.ToArray();
            DataStorageService.SaveJournalData(journalData);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения данных: {ex.Message}", "Ошибка", MessageBoxButton.OK,
                MessageBoxImage.Error);
        }
    }

    private void InitializeNotificationTimer()
    {
        _notificationTimer = new DispatcherTimer();
        _notificationTimer.Interval = TimeSpan.FromSeconds(2);
        _notificationTimer.Tick += NotificationTimer_Tick;
        _notificationTimer.Start();
    }

    private void NotificationTimer_Tick(object sender, EventArgs e)
    {
        CheckForHomeworkNotification();
    }

    private void CheckForHomeworkNotification()
    {
        try
        {
            var currentNotification = _homeworkNotificationService.GetHomeworkNotification();

            if (!string.IsNullOrWhiteSpace(currentNotification) &&
                currentNotification != _lastShownHomeworkNotification)
            {
                MessageBox.Show($"Новое домашнее задание:\n\n{currentNotification}",
                    "Уведомление о ДЗ",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                _lastShownHomeworkNotification = currentNotification;
            }
        }
        catch (Exception ex)
        {
        }
    }

    private bool CanSendHomework(object p)
    {
        return !string.IsNullOrWhiteSpace(HomeworkText);
    }

    private void SendHomework(object p)
    {
        if (!CanSendHomework(p)) return;

        try
        {
            _homeworkNotificationService.SendHomeworkNotification(HomeworkText);
            HomeworkNotification = "Задание успешно отправлено";

            _lastShownHomeworkNotification = HomeworkText;

            HomeworkText = string.Empty;
        }
        catch (Exception ex)
        {
            HomeworkNotification = $"Ошибка отправки задания: {ex.Message}";
            MessageBox.Show($"Ошибка отправки: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void Cleanup()
    {
        _notificationTimer?.Stop();
        _notificationTimer = null;

        _chatService?.StopListening();
        _chatService?.Dispose();
    }

    ~JournalViewModel()
    {
        Dispose();
    }
}