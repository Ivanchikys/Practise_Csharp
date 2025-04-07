using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace TeacherJournal
{

    public partial class MainWindow : Window
    {
        public ObservableCollection<StudentGrade> StudentGrades { get; set; }
        public ICommand AddGradeCommand { get; set; }
        public ICommand EditGradeCommand { get; set; }
        public ICommand DeleteGradeCommand { get; set; }
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
            DataContext = this;

            AddGradeCommand = new RelayCommand(_ => AddGrade());
            EditGradeCommand = new RelayCommand(_ => EditGrade(), _ => SelectedGrade != null);
            DeleteGradeCommand = new RelayCommand(_ => DeleteGrade(), _ => SelectedGrade != null);
        }

        private void StudentGradesGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
        private StudentGrade SelectedGrade => StudentGradesGrid.SelectedItem as StudentGrade;

        private void AddGrade() => StudentGrades.Add(new StudentGrade { FullName = "Новый студент" });

        private void EditGrade()
        {
            if (SelectedGrade != null)
            {
                SelectedGrade.Comment += " (изменено)";
                StudentGradesGrid.Items.Refresh();
            }
        }

        private void DeleteGrade()
        {
            if (SelectedGrade != null)
            {
                if (MessageBox.Show("Удалить выбранную оценку?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    StudentGrades.Remove(SelectedGrade);
                }
            }
        }
        private void AddGradeButton_Click(object sender, RoutedEventArgs e) => AddGrade();
        private void EditGradeButton_Click(object sender, RoutedEventArgs e) => EditGrade();
        private void DeleteGradeButton_Click(object sender, RoutedEventArgs e) => DeleteGrade();

    }
}
