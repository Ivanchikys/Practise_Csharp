using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using TeacherJournal.Commands;
using TeacherJournal.Models;
using TeacherJournal.Services;

namespace TeacherJournal.ViewModels;

public class ChatViewModel : INotifyPropertyChanged, IDisposable
{
    private readonly IChatService _chatService;
    private string _newMessageText;

    public ChatViewModel(UserModel currentUser, IChatService chatService)
    {
        CurrentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
        _chatService = chatService ?? throw new ArgumentNullException(nameof(chatService));

        Messages = new ObservableCollection<string>();
        SendMessageCommand = new RelayCommand(SendMessage, CanSendMessage);

        _chatService.MessageReceived += OnChatMessageReceived;
    }

    public ObservableCollection<string> Messages { get; }
    public ICommand SendMessageCommand { get; }

    public UserModel CurrentUser { get; }

    public string NewMessageText
    {
        get => _newMessageText;
        set => SetField(ref _newMessageText, value);
    }

    public void Dispose()
    {
        Cleanup();
        GC.SuppressFinalize(this);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private bool CanSendMessage(object parameter)
    {
        return !string.IsNullOrWhiteSpace(NewMessageText);
    }

    private void SendMessage(object parameter)
    {
        if (!CanSendMessage(parameter)) return;
        
        _chatService.SendMessage(CurrentUser.Username, NewMessageText);

        NewMessageText = string.Empty;
    }

    private void OnChatMessageReceived(string sender, string message)
    {
        AddMessageToList($"{sender}: {message}");
    }

    private void AddMessageToList(string formattedMessage)
    {
        Application.Current?.Dispatcher.Invoke(() => { Messages.Add(formattedMessage); });
    }

    public void Cleanup()
    {
        if (_chatService != null)
        {
            _chatService.MessageReceived -= OnChatMessageReceived;
        }
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}