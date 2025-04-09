using System.Windows;
using System.Windows.Input;
using TeacherJournal.Models;

namespace TeacherJournal
{
    public partial class EditGradeWindow : Window
    {
        public GradeModel EditedGrade { get; private set; }
        public string FullName { get; set; }

        public EditGradeWindow(GradeModel grade)
        {
            InitializeComponent();
            EditedGrade = new GradeModel
            {
                Grade = grade.Grade,
                Comment = grade.Comment,
                IsPresent = grade.IsPresent
            };
            FullName = grade.Enrollment?.Student?.FullName ?? "Неизвестный студент";
            DataContext = this;
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
            if (ValidateGrade(EditedGrade.Grade))
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