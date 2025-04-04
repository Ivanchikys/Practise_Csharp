namespace Task4;

public class FileWatcher
{
    private readonly FileSystemWatcher _watcher;
    private readonly string _archivePath;
    
    private readonly string[] _protectedFiles = { "important.txt", "config.json" };

    public FileWatcher(string directoryPath)
    {
        _archivePath = Path.Combine(directoryPath, "archive");
        
        DirectoryInfo archiveDir = new DirectoryInfo(_archivePath);
        if (!archiveDir.Exists)
        {
            archiveDir.Create();
            archiveDir.Attributes |= FileAttributes.Hidden;
        }
        
        foreach (var file in _protectedFiles)
        {
            string filePath = Path.Combine(directoryPath, file);
            if (File.Exists(filePath))
            {
                string backupPath = Path.Combine(_archivePath, file + ".backup");
                File.Copy(filePath, backupPath, true);
                Console.WriteLine($"Резервная копия файла {file} создана: {backupPath}");
            }
        }
        
        _watcher = new FileSystemWatcher(directoryPath)
        {
            IncludeSubdirectories = false,
            NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite | NotifyFilters.CreationTime
        };
        
        _watcher.Created += OnCreated;
        _watcher.Deleted += OnDeleted;
        _watcher.Changed += OnChanged;
        _watcher.Renamed += OnRenamed;
    }
    
    public void Start()
    {
        _watcher.EnableRaisingEvents = true;
        Console.WriteLine("FileWatcher запущен...");
    }
    
    public void Stop()
    {
        _watcher.EnableRaisingEvents = false;
        Console.WriteLine("FileWatcher остановлен");
    }
    
    private void OnCreated(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"[Created] Файл создан: {e.FullPath}");
    }
    
    private void OnDeleted(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"[Deleted] Файл удалён: {e.FullPath}");
        string fileName = Path.GetFileName(e.FullPath);
        if (Array.Exists(_protectedFiles, f => f.Equals(fileName, StringComparison.OrdinalIgnoreCase)))
        {
            RestoreProtectedFile(e.FullPath);
        }
    }
    
    private void OnChanged(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"[Changed] Файл изменён: {e.FullPath}");
        UpdateBackupIfProtected(e.FullPath);
    }
    
    private void OnRenamed(object sender, RenamedEventArgs e)
    {
        Console.WriteLine($"[Renamed] Файл переименован: {e.OldFullPath} -> {e.FullPath}");
    }
    
    private void UpdateBackupIfProtected(string filePath)
    {
        string fileName = Path.GetFileName(filePath);
        if (Array.Exists(_protectedFiles, f => f.Equals(fileName, StringComparison.OrdinalIgnoreCase)))
        {
            if (File.Exists(filePath))
            {
                string backupPath = Path.Combine(_archivePath, fileName + ".backup");
                File.Copy(filePath, backupPath, true);
                Console.WriteLine($"[BACKUP] Резервная копия файла {fileName} обновлена: {backupPath}");
            }
        }
    }
    
    private void RestoreProtectedFile(string filePath)
    {
        string fileName = Path.GetFileName(filePath);
        string backupPath = Path.Combine(_archivePath, fileName + ".backup");

        if (File.Exists(backupPath))
        {
            File.Copy(backupPath, filePath, true);
            Console.WriteLine($"[BACKUP] Файл {fileName} восстановлен из резервной копии");
        }
        else
        {
            Console.WriteLine($"[BACKUP] Резервная копия для файла {fileName} не найдена");
        }
    }
}