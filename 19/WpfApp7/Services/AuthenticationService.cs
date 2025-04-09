using System.IO;
using System.Text.Json;
using TeacherJournal.Models;

namespace TeacherJournal.Services;

public static class AuthenticationService
{
    private static readonly string UsersFilePath = "users.json";

    public static List<UserModel> LoadUsers()
    {
        if (!File.Exists(UsersFilePath))
        {
            var defaultUsers = new List<UserModel>
            {
                new() { Username = "teacher1", Password = "pass", Role = "Teacher" },
                new() { Username = "student1", Password = "pass", Role = "Student" }
            };
            SaveUsers(defaultUsers);
            return defaultUsers;
        }

        var json = File.ReadAllText(UsersFilePath);
        return JsonSerializer.Deserialize<List<UserModel>>(json);
    }

    public static void SaveUsers(List<UserModel> users)
    {
        var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(UsersFilePath, json);
    }

    public static UserModel Authenticate(string username, string password)
    {
        var users = LoadUsers();
        return users.FirstOrDefault(user => user.Username == username && user.Password == password);
    }

    public static bool VerifyPassword(string password, string hash)
    {
        return password == hash;
    }
}