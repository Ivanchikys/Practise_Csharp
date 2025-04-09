using System.IO;
using System.IO.Pipes;
using System.Windows;

namespace TeacherJournal.Services;

public class NamedPipeChatService : IChatService
{
    private const string PipeName = "TeacherJournalChatPipe";
    private CancellationTokenSource _cts;


    public event Action<string, string> MessageReceived;

    public void StartListening()
    {
        _cts = new CancellationTokenSource();
        Task.Run(() => ListenForMessages(_cts.Token));
    }

    public void SendMessage(string sender, string message)
    {
        Task.Run(async () =>
        {
            try
            {
                using (var clientStream =
                       new NamedPipeClientStream(".", PipeName, PipeDirection.InOut, PipeOptions.Asynchronous))
                {
                    await clientStream.ConnectAsync(2000);

                    if (clientStream.IsConnected)
                        using (var writer = new StreamWriter(clientStream))
                        {
                            var formattedMessage = $"{sender}:{message}";
                            await writer.WriteLineAsync(formattedMessage);
                            await writer.FlushAsync();
                        }
                }
            }
            catch (Exception ex)
            {
            }
        });
    }

    public void StopListening()
    {
        _cts?.Cancel();
        _cts?.Dispose();
        _cts = null;

        try
        {
            using (var dummyClient = new NamedPipeClientStream(".", PipeName, PipeDirection.Out))
            {
                dummyClient.Connect(50);
            }
        }
        catch
        {
        }
    }

    public void Dispose()
    {
        StopListening();
    }

    private async Task ListenForMessages(CancellationToken token)
    {
        while (!token.IsCancellationRequested)
            try
            {
                using (var serverStream = new NamedPipeServerStream(PipeName, PipeDirection.InOut,
                           NamedPipeServerStream.MaxAllowedServerInstances, PipeTransmissionMode.Message,
                           PipeOptions.Asynchronous))
                {
                    await serverStream.WaitForConnectionAsync(token);

                    using (var reader = new StreamReader(serverStream))
                    {
                        var line = await reader.ReadLineAsync();
                        if (line != null)
                        {
                            var parts = line.Split(new[] { ':' }, 2);
                            if (parts.Length == 2)
                                Application.Current?.Dispatcher.Invoke(() =>
                                {
                                    MessageReceived?.Invoke(parts[0].Trim(), parts[1].Trim());
                                });
                        }
                    }
                }
            }
            catch (OperationCanceledException)
            {
                break;
            }
            catch (Exception ex)
            {
                await Task.Delay(1000);
            }
    }
}