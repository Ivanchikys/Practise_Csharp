using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TeacherJournal
{
    public class JournalViewModel : INotifyPropertyChanged
    {
        private readonly JournalService _journalService = new JournalService();

        public ObservableCollection<CourseModel> Courses { get; set; } = new();
        public ObservableCollection<GradeModel> Grades { get; set; } = new();

        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set { _isLoading = value; OnPropertyChanged(nameof(IsLoading)); }
        }

        public ICommand EditGradeCommand { get; set; }

        public JournalViewModel()
        {
            EditGradeCommand = new RelayCommand(EditSelectedGrade);
            LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            IsLoading = true;

            Courses = new ObservableCollection<CourseModel>(_journalService.LoadCourses());
            var grades = await _journalService.LoadGradesAsync();

            Grades.Clear();
            foreach (var g in grades)
                Grades.Add(g);

            IsLoading = false;
        }

        private void EditSelectedGrade(object obj)
        {
            if (obj is GradeModel grade)
            {
                grade.Comment += " (изменено)";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
