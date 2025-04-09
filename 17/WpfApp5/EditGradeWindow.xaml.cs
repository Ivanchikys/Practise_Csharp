using System;
using System.Windows;
using System.Windows.Input;
using TeacherJournal.Models;

namespace TeacherJournal
{
    public partial class EditGradeWindow : Window
    {
        public StudentGradeItem EditedStudent { get; private set; }

        public EditGradeWindow(StudentGradeItem student)
        {
            InitializeComponent();
            EditedStudent = new StudentGradeItem
            {
                FullName = student.FullName,
                Grade = student.Grade,
                Comment = student.Comment,
                IsPresent = student.IsPresent
            };
            DataContext = EditedStudent;
        }

        public string FullName
        {
            get => EditedStudent.FullName;
            set => EditedStudent.FullName = value;
        }

        public string NewGrade
        {
            get => EditedStudent.Grade;
            set => EditedStudent.Grade = value;
        }

        public string Comment
        {
            get => EditedStudent.Comment;
            set => EditedStudent.Comment = value;
        }

        public bool IsPresent
        {
            get => EditedStudent.IsPresent;
            set => EditedStudent.IsPresent = value;
        }

        private void GradeTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsNumericInput(e.Text);
        }

        private bool IsNumericInput(string input)
        {
            return int.TryParse(input, out _);
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateGrade(NewGrade))
            {
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Оценка должна быть числом от 0 до 10.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
        
        private bool ValidateGrade(string grade)
        {
            if (string.IsNullOrWhiteSpace(grade)) return true;
            if (int.TryParse(grade, out int value))
            {
                return value >= 0 && value <= 10;
            }
            return false;
        }
    }
}