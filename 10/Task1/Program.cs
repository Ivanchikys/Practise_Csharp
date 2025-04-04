using Task1;

var fm = new FileManager();
var fip = new FileInfoProvider();

const string fileName = "Yarosheya.ps";

Console.WriteLine("1. Создание и чтение файла");
fm.CreateFile(fileName, "berka birka");
Console.WriteLine("Файл создан.");
Console.WriteLine(File.ReadAllText(fileName));

var info = fip.GetFileInfo(fileName);
Console.WriteLine("2. Информация о файле");
Console.WriteLine($"Размер: {info.Size} байт, Дата создания: {info.Created}");

fm.CopyFile(fileName, "copy.txt");
Console.WriteLine("3. Копирование файла");
Console.WriteLine($"Файл скопирован: {File.Exists("copy.txt")}");

Console.WriteLine("4. Сравнение размеров");
Console.WriteLine($"Файлы одинаковы: {fip.CompareSizes(fileName, "copy.txt")}");

fm.SetFileReadOnly(fileName, true);
Console.WriteLine("5. Попытка записи в readonly файл");
try
{
    File.WriteAllText(fileName, "Попытка записи в readonly файл");
}
catch (Exception e)
{
    Console.WriteLine($"Ошибка: {e.Message}");
}
finally
{
    fm.SetFileReadOnly(fileName, false);
}

var perms = fip.CheckPermissions(fileName);
Console.WriteLine("6. Права доступа");
Console.WriteLine($"Чтение: {perms.Read}, Запись: {perms.Write}");

Directory.CreateDirectory("new_dir");
fm.MoveFile(fileName, $"new_dir/{fileName}");
Console.WriteLine("7. Перемещение файла");
Console.WriteLine($"Файл в 'new_dir': {File.Exists($"new_dir/{fileName}")}");

fm.RenameFile($"new_dir/{fileName}", "familiya.io");
Console.WriteLine("8. Переименование файла");
Console.WriteLine($"Файл 'familiya.io' создан: {File.Exists("new_dir/familiya.io")}");

Console.WriteLine("9. Удаление несуществующего файла");
try 
{ 
    fm.DeleteFile("no.file"); 
}
catch (FileNotFoundException e) 
{ 
    Console.WriteLine($"Ошибка: {e.Message}");
}

fm.CreateFile("template.ps", "berka birka");
fm.DeleteFilesByPattern(".", "*.ps");
Console.WriteLine("10. Удаление файлов по шаблону");
Console.WriteLine("Файлы с расширением '.ps' удалены.");

var files = fm.GetFilesInDirectory(".");
Console.WriteLine("11. Список файлов в директории");
Console.WriteLine(string.Join("\n", files));

fm.CreateFile(fileName, "berka birka");
var newPerms = fip.CheckPermissions(fileName);
Console.WriteLine("12. Проверка прав нового файла");
Console.WriteLine($"Чтение: {newPerms.Read}, Запись: {newPerms.Write}");
