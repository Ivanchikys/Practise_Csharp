using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TeacherJournal.Commands;
using TeacherJournal.Models;
using TeacherJournal.Services;

namespace TeacherJournal.ViewModels
{
    public class JournalViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<StudentGradeItem> StudentGrades { get; set; } = new ObservableCollection<StudentGradeItem>();

        public ObservableCollection<CourseModel> Courses { get; set; } = new ObservableCollection<CourseModel>();

        private Dictionary<string, ObservableCollection<StudentGradeItem>> _courseCache
            = new Dictionary<string, ObservableCollection<StudentGradeItem>>();

        private StudentGradeItem _selectedGrade;
        public StudentGradeItem SelectedGrade
        {
            get => _selectedGrade;
            set
            {
                _selectedGrade = value;
                OnPropertyChanged(nameof(SelectedGrade));
                (EditGradeCommand as RelayCommand)?.RaiseCanExecuteChanged();
                (DeleteGradeCommand as RelayCommand)?.RaiseCanExecuteChanged();
            }
        }

        private CourseModel _selectedCourse;
        public CourseModel SelectedCourse
        {
            get => _selectedCourse;
            set
            {
                if (_selectedCourse != value)
                {
                    _selectedCourse = value;
                    OnPropertyChanged(nameof(SelectedCourse));
                    _ = LoadDataAsync();
                }
            }
        }

        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set { _isLoading = value; OnPropertyChanged(nameof(IsLoading)); }
        }

        public ICommand AddGradeCommand { get; }
        public ICommand EditGradeCommand { get; }
        public ICommand DeleteGradeCommand { get; }

        public JournalViewModel()
        {
            AddGradeCommand = new RelayCommand(_ => AddGrade());
            EditGradeCommand = new RelayCommand(_ => EditGrade(), _ => SelectedGrade != null);
            DeleteGradeCommand = new RelayCommand(_ => DeleteGrade(), _ => SelectedGrade != null);

            Courses.Add(new CourseModel { CourseName = "КПиЯП" });
            Courses.Add(new CourseModel { CourseName = "Практика" });
            Courses.Add(new CourseModel { CourseName = "ТПО" });
            SelectedCourse = Courses[0];
        }

        public async Task LoadDataAsync()
        {
            if (SelectedCourse == null)
                return;

            IsLoading = true;
            if (_courseCache.ContainsKey(SelectedCourse.CourseName))
            {
                StudentGrades.Clear();
                foreach (var item in _courseCache[SelectedCourse.CourseName])
                    StudentGrades.Add(item);
            }
            else
            {
                var loadedStudents = await JournalService.LoadStudentGradesAsync(SelectedCourse);
                StudentGrades.Clear();
                foreach (var student in loadedStudents)
                    StudentGrades.Add(student);
                _courseCache[SelectedCourse.CourseName] = new ObservableCollection<StudentGradeItem>(StudentGrades);
            }
            IsLoading = false;
        }

        private void AddGrade()
        {
            var newStudentGrade = new StudentGradeItem
            {
                FullName = "Новый студент",
                Grade = "0",
                Comment = "Новая оценка",
                IsPresent = false,
                CourseName = SelectedCourse?.CourseName ?? ""
            };
            StudentGrades.Add(newStudentGrade);

            if (SelectedCourse != null)
            {
                if (_courseCache.ContainsKey(SelectedCourse.CourseName))
                {
                    _courseCache[SelectedCourse.CourseName].Add(newStudentGrade);
                }
                else
                {
                    _courseCache[SelectedCourse.CourseName] = new ObservableCollection<StudentGradeItem> { newStudentGrade };
                }
            }
        }

        private void EditGrade()
        {
            if (SelectedGrade != null)
            {
                SelectedGrade.Comment += " (изменено)";
            }
        }

        private void DeleteGrade()
        {
            if (SelectedGrade != null)
            {
                if (MessageBox.Show("Удалить выбранную оценку?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    StudentGrades.Remove(SelectedGrade);
                    if (SelectedCourse != null && _courseCache.ContainsKey(SelectedCourse.CourseName))
                    {
                        _courseCache[SelectedCourse.CourseName].Remove(SelectedGrade);
                    }
                    SelectedGrade = null;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
