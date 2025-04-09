namespace TeacherJournal.Services;

public class HomeworkNotificationService
{
    private readonly MemoryMappedFileService _memoryMappedFileService;

    public HomeworkNotificationService(MemoryMappedFileService memoryMappedFileService)
    {
        _memoryMappedFileService = memoryMappedFileService;
    }

    public void SendHomeworkNotification(string homeworkText)
    {
        _memoryMappedFileService.WriteHomeworkNotification(homeworkText);
    }

    public string GetHomeworkNotification()
    {
        return _memoryMappedFileService.ReadHomeworkNotification();
    }
}