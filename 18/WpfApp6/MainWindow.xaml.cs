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

    private async void Window_Loaded(object sender, RoutedEventArgs e)
    {
        await _viewModel.LoadDataAsync();
    }

    private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
    {
        _viewModel.EditGrade();
    }

    private void Logout_Click(object sender, RoutedEventArgs e)
    {
        if (DataContext is JournalViewModel vm)
            vm.Cleanup();
        var loginWindow = new LoginWindow();
        Application.Current.MainWindow = loginWindow;
        loginWindow.Show();
        Close();
    }
    
    private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        if (sender is DataGrid dataGrid && dataGrid.SelectedItem is StudentGradeItem selectedStudent)
        {
            var summaryWindow = new StudentSummaryWindow(selectedStudent, _viewModel.StudentGrades);
            summaryWindow.ShowDialog();
        }
    }
    
    protected override void OnClosing(CancelEventArgs e)
    {
        if (DataContext is JournalViewModel vm)
            vm.Cleanup();
        base.OnClosing(e);
    }
}