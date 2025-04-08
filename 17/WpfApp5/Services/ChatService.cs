using System;
using System.IO.Pipes;
using System.Text;
using System.Threading.Tasks;

namespace TeacherJournal.Services
{
    public static class ChatService
    {
        public static async Task StartChatServerAsync(string pipeName)
        {
            using (var server = new NamedPipeServerStream(pipeName, PipeDirection.InOut, 1))
            {
                await server.WaitForConnectionAsync();
                byte[] buffer = new byte[1024];
                int bytesRead = await server.ReadAsync(buffer, 0, buffer.Length);
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Получено сообщение: " + message);
            }
        }
        public static async Task SendChatMessageAsync(string pipeName, string message)
        {
            using (var client = new NamedPipeClientStream(".", pipeName, PipeDirection.Out))
            {
                await client.ConnectAsync(5000);
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                await client.WriteAsync(buffer, 0, buffer.Length);
            }
        }
    }
}
