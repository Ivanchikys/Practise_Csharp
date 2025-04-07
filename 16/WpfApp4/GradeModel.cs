using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherJournal
{
    public class GradeModel : INotifyPropertyChanged
    {
        private string _grade;
        private string _comment;
        private bool _isPresent;

        public StudentModel Student { get; set; }

        public string Grade
        {
            get => _grade;
            set
            {
                _grade = value;
                OnPropertyChanged(nameof(Grade));
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

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
