namespace Task3;

public class MoveFileCommand(FileManager fileManager, string source, string destination) : ICommand
{
    private readonly FileManager _fileManager = fileManager;
    private readonly string _source = source;
    private readonly string _destination = destination;
    public void Execute()
    {
        _fileManager.MoveFile(_source, _destination);
    }
}