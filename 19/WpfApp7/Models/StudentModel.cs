using System.ComponentModel;

namespace TeacherJournal.Models
{
    public class StudentModel : INotifyPropertyChanged
    {
        private string _fullName;

        public int Id { get; set; }
        public string FullName
        {
            get => _fullName;
            set
            {
                _fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }
        public ICollection<Enrollment> Enrollments { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}