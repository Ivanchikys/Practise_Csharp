using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using TeacherJournal.Models;
using TeacherJournal.ViewModels;

namespace TeacherJournal;

public partial class MainWindow : Window
{
    private readonly JournalViewModel _viewModel;

    public MainWindow(UserModel currentUser)
    {
        InitializeComponent();
        CurrentUser = currentUser;
        _viewModel = new JournalViewModel(CurrentUser);
        DataContext = _viewModel;
    }

    public UserModel CurrentUser { get; }

    private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        if (sender is DataGrid dataGrid && dataGrid.SelectedItem is Enrollment selectedEnrollment)
        {
            var summaryWindow = new StudentSummaryWindow(selectedEnrollment, _viewModel.Enrollments);
            summaryWindow.ShowDialog();
        }
    }
    
    private async void Window_Loaded(object sender, RoutedEventArgs e)
    {
        await _viewModel.LoadEnrollmentsAsync();
    }
}