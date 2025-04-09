using System.ComponentModel;

namespace TeacherJournal.Models
{
    public class GradeModel : INotifyPropertyChanged
    {
        private string _comment;
        private string _grade;
        private bool _isPresent;

        public int Id { get; set; }
        public int EnrollmentId { get; set; }
        public Enrollment Enrollment { get; set; }

        public string Grade
        {
            get => _grade;
            set
            {
                _grade = value;
                OnPropertyChanged(nameof(Grade));
                OnPropertyChanged(nameof(Average));
            }
        }

        public string Comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }

        public bool IsPresent
        {
            get => _isPresent;
            set
            {
                _isPresent = value;
                OnPropertyChanged(nameof(IsPresent));
            }
        }

        public double Average => double.TryParse(Grade, out var g) ? g : 0;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}