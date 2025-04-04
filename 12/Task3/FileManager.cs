namespace Task3;

public class FileManager
{
    public void CopyFile(string source, string destination)
    {
        File.Copy(source, destination, true);
        Console.WriteLine($"Файл скопирован: {source} -> {destination}");
    }

    public void MoveFile(string source, string destination)
    {
        File.Move(source, destination, true);
        Console.WriteLine($"Файл перемещён: {source} -> {destination}");
    }
}