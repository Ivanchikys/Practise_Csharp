using System;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace TeacherJournal.Services
{
    public class MemoryMappedFileService
    {
        private const string MemoryMappedFileName = "HomeworkNotifications";

        public void WriteHomeworkNotification(string homeworkText)
        {
            try
            {
                using (var mmf = MemoryMappedFile.CreateOrOpen(MemoryMappedFileName, 1024))
                {
                    using (var accessor = mmf.CreateViewAccessor())
                    {
                        byte[] data = Encoding.UTF8.GetBytes(homeworkText);
                        accessor.Write(0, (byte)data.Length);
                        accessor.WriteArray(1, data, 0, data.Length);  
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Ошибка записи в MemoryMappedFile: {ex.Message}", ex);
            }
        }

        public string ReadHomeworkNotification()
        {
            try
            {
                using (var mmf = MemoryMappedFile.OpenExisting(MemoryMappedFileName))
                {
                    using (var accessor = mmf.CreateViewAccessor())
                    {
                        byte length = accessor.ReadByte(0);
                        byte[] data = new byte[length];
                        accessor.ReadArray(1, data, 0, length);
                        return Encoding.UTF8.GetString(data);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Ошибка чтения из MemoryMappedFile: {ex.Message}", ex);
            }
        }
    }
}
