using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public List<Student> Students { get; set; }
        public List<JournalEntry> JournalEntries { get; set; }
        public List<int> PossibleGrades { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            InitializeData();

            StudentsComboBox.ItemsSource = Students;
            GradeComboBox.ItemsSource = PossibleGrades;
            JournalDataGrid.ItemsSource = JournalEntries;
        }

        private void InitializeData()
        {
            Students = new List<Student>
            {
                new Student { Id = 1, FirstName = "Иван", LastName = "Ерошеня", Group = "ТП-40" },
                new Student { Id = 2, FirstName = "Павел", LastName = "Джангиров", Group = "ТП-40" },
                new Student { Id = 3, FirstName = "Мария", LastName = "Новик", Group = "ТП-40" },
                new Student { Id = 4, FirstName = "Кирилл", LastName = "Рогожинский", Group = "ТП-41" }
            };
            PossibleGrades = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            JournalEntries = new List<JournalEntry>();
        }

        private void AddGrade_Click(object sender, RoutedEventArgs e)
        {
            if (StudentsComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите студента!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (GradeDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Укажите дату!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(SubjectTextBox.Text))
            {
                MessageBox.Show("Введите предмет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (GradeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите оценку!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            var newEntry = new JournalEntry
            {
                Student = (Student)StudentsComboBox.SelectedItem,
                Date = GradeDatePicker.SelectedDate.Value,
                Subject = SubjectTextBox.Text,
                Grade = (int)GradeComboBox.SelectedItem,
                Comment = CommentTextBox.Text,
                IsPresent = AttendanceCheckBox.IsChecked ?? true
            };
            JournalEntries.Add(newEntry);
            JournalDataGrid.Items.Refresh();
            MessageBox.Show("Оценка успешно добавлена!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
  