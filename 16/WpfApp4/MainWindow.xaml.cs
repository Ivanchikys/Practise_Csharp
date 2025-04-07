using System.Windows;
using TeacherJournal.ViewModels;

namespace TeacherJournal
{
    public partial class MainWindow : Window
    {
        private JournalViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new JournalViewModel();
            DataContext = _viewModel;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadDataAsync();
        }
    }
}
