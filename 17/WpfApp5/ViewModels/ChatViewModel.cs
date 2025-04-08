using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TeacherJournal.Commands;
using TeacherJournal.Models;
using TeacherJournal.Services;
using System.Diagnostics;
using System.Windows;

namespace TeacherJournal.ViewModels
{
    public class ChatViewModel : INotifyPropertyChanged, IDisposable
    {
        private readonly IChatService _chatService;
        private readonly UserModel _currentUser;
        private string _newMessageText;

        public ObservableCollection<string> Messages { get; }
        public ICommand SendMessageCommand { get; }

        public UserModel CurrentUser => _currentUser;

        public string NewMessageText
        {
            get => _newMessageText;
            set => SetField(ref _newMessageText, value);
        }

        public ChatViewModel(UserModel currentUser, IChatService chatService)
        {
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
            _chatService = chatService ?? throw new ArgumentNullException(nameof(chatService));

            Messages = new ObservableCollection<string>();
            SendMessageCommand = new RelayCommand(SendMessage, CanSendMessage);

            _chatService.MessageReceived += OnChatMessageReceived;

            Debug.WriteLine($"ChatViewModel Initialized for {currentUser.Username}. Subscribed to Chat Service.");
        }

        private bool CanSendMessage(object parameter)
        {
            return !string.IsNullOrWhiteSpace(NewMessageText);
        }

        private void SendMessage(object parameter)
        {
            if (!CanSendMessage(parameter)) return;

            Debug.WriteLine($"ChatViewModel: Sending message: {NewMessageText}");
            _chatService.SendMessage(_currentUser.Username, NewMessageText);

            NewMessageText = string.Empty; 
        }

        private void OnChatMessageReceived(string sender, string message)
        {
            Debug.WriteLine($"ChatViewModel: Received message from {sender}: {message}");
            AddMessageToList($"{sender}: {message}");
        }

        private void AddMessageToList(string formattedMessage)
        {
            Application.Current?.Dispatcher.Invoke(() =>
            {
                Messages.Add(formattedMessage);
            });
        }

        public void Cleanup()
        {
            Debug.WriteLine("ChatViewModel: Cleaning up...");
            if (_chatService != null)
            {
                _chatService.MessageReceived -= OnChatMessageReceived; 
                Debug.WriteLine("ChatViewModel: Unsubscribed from Chat Service.");
            }
        }

        public void Dispose()
        {
            Cleanup();
            GC.SuppressFinalize(this);
        }

        ~ChatViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

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
}