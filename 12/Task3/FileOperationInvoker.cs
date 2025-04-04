namespace Task3;

public class FileOperationInvoker
{
    private ICommand _command;
    
    public void SetCommand(ICommand command)
    {
        _command = command;
    }
    
    public void ExecuteCommand()
    {
        if (_command != null)
            _command.Execute();
    }
}
