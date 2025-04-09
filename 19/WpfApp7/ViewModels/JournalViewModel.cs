using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using TeacherJournal.Commands;
using TeacherJournal.Data;
using TeacherJournal.Models;
using TeacherJournal.Services;

namespace TeacherJournal.ViewModels
{
    public class JournalViewModel : INotifyPropertyChanged, IDisposable
    {
        private readonly IChatService _chatService;
        private readonly HomeworkNotificationService _homeworkNotificationService;
        private readonly JournalContext _context;
        private readonly CourseRepository _courseRepository;
        private readonly EnrollmentRepository _enrollmentRepository;
        private readonly GradeRepository _gradeRepository;

        private UserModel _currentUser;
        private CourseModel _selectedCourse;
        private Enrollment _selectedEnrollment;
        private string _homeworkText;
        private string _homeworkNotification;
        private string _lastShownHomeworkNotification;
        private bool _isLoading;
        private DispatcherTimer _notificationTimer;

        public JournalViewModel(UserModel currentUser)
        {
            _context = new JournalContext();
            _courseRepository = new CourseRepository(_context);
            _enrollmentRepository = new EnrollmentRepository(_context);
            _gradeRepository = new GradeRepository(_context);
            _homeworkNotificationService = new HomeworkNotificationService(new MemoryMappedFileService());
            _chatService = new NamedPipeChatService();
            _chatService.StartListening();

            CurrentUser = currentUser;
            Courses = new ObservableCollection<CourseModel>();
            Enrollments = new ObservableCollection<Enrollment>();

            AddGradeCommand = new RelayCommand(async _ => await AddGrade(), _ => SelectedCourse != null);
            EditGradeCommand = new RelayCommand(async _ => await EditGrade(), _ => SelectedEnrollment != null);
            DeleteGradeCommand = new RelayCommand(async _ => await DeleteGrade(), _ => SelectedEnrollment != null);
            SendHomeworkCommand = new RelayCommand(SendHomework, CanSendHomework);
            OpenChatCommand = new RelayCommand(OpenChatWindow);

            InitializeNotificationTimer();
            LoadCoursesAsync();
        }

        public ObservableCollection<CourseModel> Courses { get; set; }
        public ObservableCollection<Enrollment> Enrollments { get; set; }

        public ICommand AddGradeCommand { get; }
        public ICommand EditGradeCommand { get; }
        public ICommand DeleteGradeCommand { get; }
        public ICommand SendHomeworkCommand { get; }
        public ICommand OpenChatCommand { get; }

        public UserModel CurrentUser
        {
            get => _currentUser;
            set
            {
                _currentUser = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsTeacher));
                OnPropertyChanged(nameof(IsStudent));
            }
        }

        public CourseModel SelectedCourse
        {
            get => _selectedCourse;
            set
            {
                _selectedCourse = value;
                OnPropertyChanged();
                LoadEnrollmentsAsync();
            }
        }

        public Enrollment SelectedEnrollment
        {
            get => _selectedEnrollment;
            set
            {
                _selectedEnrollment = value;
                OnPropertyChanged();
            }
        }

        public string HomeworkText
        {
            get => _homeworkText;
            set
            {
                _homeworkText = value;
                OnPropertyChanged();
            }
        }

        public string HomeworkNotification
        {
            get => _homeworkNotification;
            set
            {
                _homeworkNotification = value;
                OnPropertyChanged();
            }
        }

        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged();
            }
        }

        public bool IsTeacher => CurrentUser?.Role == "Teacher";
        public bool IsStudent => !IsTeacher;

        public event PropertyChangedEventHandler PropertyChanged;

        private async void LoadCoursesAsync()
        {
            IsLoading = true;
            try
            {
                var courses = await _courseRepository.GetAllCoursesAsync();
                Courses.Clear();
                foreach (var course in courses)
                {
                    Courses.Add(course);
                }
                SelectedCourse = Courses.FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки курсов: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                IsLoading = false;
            }
        }

        public async Task LoadEnrollmentsAsync()
        {
            if (SelectedCourse == null)
            {
                Enrollments.Clear();
                return;
            }

            IsLoading = true;
            try
            {
                var enrollments = await _enrollmentRepository.GetEnrollmentsByCourseAsync(SelectedCourse.Id);
                Enrollments.Clear();
                foreach (var enrollment in enrollments)
                {
                    if (enrollment.Grades == null || !enrollment.Grades.Any())
                    {
                        enrollment.Grades = new List<GradeModel> { new GradeModel { Grade = "Н/А", Comment = "", IsPresent = false } };
                    }
                    Enrollments.Add(enrollment);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                IsLoading = false;
            }
        }

        private async Task AddGrade()
        {
            if (SelectedCourse == null)
            {
                MessageBox.Show("Сначала выберите курс.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            var newEnrollment = new Enrollment
            {
                CourseId = SelectedCourse.Id,
                Student = new StudentModel { FullName = "Новый студент" },
                Grades = new List<GradeModel> { new GradeModel { Grade = "Н/А", Comment = "", IsPresent = true } }
            };

            await _enrollmentRepository.AddEnrollmentAsync(newEnrollment);
            await LoadEnrollmentsAsync();
            SelectedEnrollment = Enrollments.FirstOrDefault(e => e.Id == newEnrollment.Id);
        }

        private async Task EditGrade()
        {
            if (SelectedEnrollment == null) return;

            var grade = SelectedEnrollment.Grades.FirstOrDefault();
            if (grade != null)
            {
                var editWindow = new EditGradeWindow(grade);
                if (editWindow.ShowDialog() == true)
                {
                    grade.Grade = editWindow.EditedGrade.Grade;
                    grade.Comment = editWindow.EditedGrade.Comment;
                    grade.IsPresent = editWindow.EditedGrade.IsPresent;
                    SelectedEnrollment.Student.FullName = editWindow.FullName; // Обновляем имя студента
                    await _enrollmentRepository.UpdateEnrollmentAsync(SelectedEnrollment);
                    await _gradeRepository.UpdateGradeAsync(grade);
                    OnPropertyChanged(nameof(SelectedEnrollment));
                }
            }
        }

        private async Task DeleteGrade()
        {
            if (SelectedEnrollment == null) return;

            if (MessageBox.Show($"Удалить запись для студента '{SelectedEnrollment.Student.FullName}'?", "Подтверждение удаления",
                    MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                await _enrollmentRepository.DeleteEnrollmentAsync(SelectedEnrollment.Id);
                await LoadEnrollmentsAsync();
                SelectedEnrollment = null;
            }
        }

        private void SendHomework(object parameter)
        {
            if (!CanSendHomework(parameter)) return;

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

        private bool CanSendHomework(object parameter)
        {
            return !string.IsNullOrWhiteSpace(HomeworkText);
        }

        private void OpenChatWindow(object parameter)
        {
            var chatViewModel = new ChatViewModel(CurrentUser, _chatService);
            var chatWindow = new ChatWindow(chatViewModel)
            {
                Owner = Application.Current.MainWindow
            };
            chatWindow.Show();
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
                if (!string.IsNullOrWhiteSpace(currentNotification) && currentNotification != _lastShownHomeworkNotification)
                {
                    MessageBox.Show($"Новое домашнее задание:\n\n{currentNotification}", "Уведомление о ДЗ", MessageBoxButton.OK, MessageBoxImage.Information);
                    _lastShownHomeworkNotification = currentNotification;
                }
            }
            catch (Exception) { }
        }

        public void Dispose()
        {
            _notificationTimer?.Stop();
            _chatService?.StopListening();
            _chatService?.Dispose();
            _context.Dispose();
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}