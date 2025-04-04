using Task4;

const string folderToWatch = @".";

var watcher = new FileWatcher(folderToWatch);
watcher.Start();

Console.WriteLine("FileWatcher запущен. Нажмите 'q' для выхода");
                    
var exit = false;
while (!exit)
{
    var key = Console.ReadKey(true);
    if (key.KeyChar == 'q')
        exit = true;
}
                    
watcher.Stop();