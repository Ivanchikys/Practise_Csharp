using Task3;

FileManager fileManager = new FileManager();

FileOperationInvoker invoker = new FileOperationInvoker();

ICommand copyCommand = new CopyFileCommand(fileManager, "input.txt", "copy.txt");
invoker.SetCommand(copyCommand);
invoker.ExecuteCommand();

ICommand moveCommand = new MoveFileCommand(fileManager, "copy.txt", "moved.txt");
invoker.SetCommand(moveCommand);
invoker.ExecuteCommand();