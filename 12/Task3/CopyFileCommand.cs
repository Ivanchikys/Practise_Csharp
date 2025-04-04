namespace Task3;

public class CopyFileCommand : ICommand
{
    private readonly FileManager _fileManager;
    private readonly string _source;
    private readonly string _destination;

    public CopyFileCommand(FileManager fileManager, string source, string destination)
    {
        _fileManager = fileManager;
        _source = source;
        _destination = destination;
    }

    public void Execute()
    {
        _fileManager.CopyFile(_source, _destination);
    }
}
