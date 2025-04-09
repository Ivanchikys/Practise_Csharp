using System.Windows;
using TeacherJournal.Models;
using TeacherJournal.Services;

namespace TeacherJournal;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        var login = LoginTextBox.Text;
        var password = PasswordBox.Password;
        var users = AuthenticationService.LoadUsers();
        var user = users.FirstOrDefault(u =>
            u.Username == login && AuthenticationService.VerifyPassword(password, u.Password));
        if (user != null)
        {
            var mainWindow = new MainWindow(user);
            Application.Current.MainWindow = mainWindow;
            mainWindow.Show();
            Close();
        }
        else
        {
            MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }

    private void RegisterButton_Click(object sender, RoutedEventArgs e)
    {
        var login = LoginTextBox.Text;
        var password = PasswordBox.Password;
        var users = AuthenticationService.LoadUsers();
        if (users.Any(u => u.Username == login))
        {
            MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка", MessageBoxButton.OK,
                MessageBoxImage.Warning);
            return;
        }

        var newUser = new UserModel { Username = login, Password = password, Role = "User" };
        users.Add(newUser);
        AuthenticationService.SaveUsers(users);
        MessageBox.Show("Регистрация успешна", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}