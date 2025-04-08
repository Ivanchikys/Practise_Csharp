using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherJournal.Services
{
    public interface IChatService : IDisposable
    {
        event Action<string, string> MessageReceived;
        void StartListening();
        void StopListening();
        void SendMessage(string sender, string message);
    }
}
