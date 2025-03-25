using Task3;

ServerConnection server = new ServerConnection();
try
{
    Console.Write("Введите количество активных подключений: ");
    int activeConnections = int.Parse(Console.ReadLine());
    server.Connect(activeConnections);
}
catch (TooManyConnectionsException ex)
{Console.WriteLine($"Ошибка: {ex.Message}");}
catch (FormatException)
{Console.WriteLine("Ошибка: введено некорректное значение!");}