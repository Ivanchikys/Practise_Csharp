using System.Windows;
using TeacherJournal.Models;
using TeacherJournal.Services;
using TeacherJournal.ViewModels;

namespace TeacherJournal
{
    public partial class MainWindow : Window
    {
        private JournalViewModel _viewModel;
        private readonly UserModel _currentUser;
        public UserModel CurrentUser => _currentUser;

        public MainWindow(UserModel currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _viewModel = new JournalViewModel(_currentUser);
            DataContext = _viewModel;
         

        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadDataAsync();
        }

        private void DataGrid_CellEditEnding(object sender, System.Windows.Controls.DataGridCellEditEndingEventArgs e) => _viewModel.SaveChanges();

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is JournalViewModel vm)
                vm.Cleanup();
            var loginWindow = new LoginWindow();
            Application.Current.MainWindow = loginWindow;
            loginWindow.Show();
            Close();
        }


        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            if (DataContext is JournalViewModel vm)
                vm.Cleanup();
            base.OnClosing(e);
        }
    }
}
