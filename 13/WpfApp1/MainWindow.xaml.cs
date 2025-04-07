using System.Collections.ObjectModel;
using System.Windows;

namespace TeacherJournal
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<StudentGrade> StudentGrades { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            StudentGrades = new ObservableCollection<StudentGrade>
            {
                new StudentGrade { FullName = "Ерошеня И.С.", Grade = "9", Comment = "Молочинка" },
                new StudentGrade { FullName = "Джангиров П.С.", Grade = "9", Comment = "Хороший работяга" }
            };

            SubjectComboBox.ItemsSource = new string[] { "КПиЯП", "Практика", "ТПО" };
            SubjectComboBox.SelectedIndex = 0;
            StudentGradesGrid.ItemsSource = StudentGrades;
        }

        private void AddGradeButton_Click(object sender, RoutedEventArgs e)
        {
            StudentGrades.Add(new StudentGrade
            {
                FullName = "Новый студент",
                Grade = "",
                Comment = ""
            });
        }

        private void StudentGradesGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
