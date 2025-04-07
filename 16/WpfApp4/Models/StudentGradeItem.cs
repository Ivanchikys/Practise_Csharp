using System.ComponentModel;

namespace TeacherJournal.Models
{
    public class StudentGradeItem : INotifyPropertyChanged
    {
        public StudentModel Student { get; set; } = new StudentModel();
        public GradeModel GradeInfo { get; set; } = new GradeModel();

        public string CourseName { get; set; }

        public string FullName
        {
            get => Student.FullName;
            set { Student.FullName = value; OnPropertyChanged(nameof(FullName)); }
        }

        public string Grade
        {
            get => GradeInfo.Grade;
            set { GradeInfo.Grade = value; OnPropertyChanged(nameof(Grade)); OnPropertyChanged(nameof(Average)); }
        }

        public string Comment
        {
            get => GradeInfo.Comment;
            set { GradeInfo.Comment = value; OnPropertyChanged(nameof(Comment)); }
        }

        public bool IsPresent
        {
            get => GradeInfo.IsPresent;
            set { GradeInfo.IsPresent = value; OnPropertyChanged(nameof(IsPresent)); }
        }

        public double Average => GradeInfo.Average;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
