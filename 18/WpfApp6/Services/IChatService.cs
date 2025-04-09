namespace TeacherJournal.Services;

public interface IChatService : IDisposable
{
    event Action<string, string> MessageReceived;
    void StartListening();
    void StopListening();
    void SendMessage(string sender, string message);
}