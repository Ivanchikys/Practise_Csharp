using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherJournal
{
    using System.ComponentModel;

    public class StudentGrade : INotifyPropertyChanged
    {
        private string grade;
        private bool isPresent;

        public string FullName { get; set; }

        public string Grade
        {
            get => grade;
            set
            {
                grade = value;
                OnPropertyChanged(nameof(Grade));
                OnPropertyChanged(nameof(Average));
            }
        }

        public string Comment { get; set; }

        public bool IsPresent
        {
            get => isPresent;
            set
            {
                isPresent = value;
                OnPropertyChanged(nameof(IsPresent));
            }
        }

        public double Average => double.TryParse(Grade, out var g) ? g : 0;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
