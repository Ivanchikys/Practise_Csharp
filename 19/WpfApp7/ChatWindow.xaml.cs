using System.ComponentModel;
using System.Windows;
using TeacherJournal.ViewModels;

namespace TeacherJournal;

public partial class ChatWindow : Window
{
    private readonly ChatViewModel _viewModel;

    public ChatWindow(ChatViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        DataContext = _viewModel;
    }

    private void Window_Closing(object sender, CancelEventArgs e)
    {
        _viewModel?.Cleanup();
    }
}