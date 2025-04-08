using System.IO;
using System.Text.Json;
using TeacherJournal.Models;

namespace TeacherJournal.Services
{
    public static class DataStorageService
    {
        private static readonly string JournalFilePath = "journal.json";

        public static JournalData LoadJournalData()
        {
            if (!File.Exists(JournalFilePath))
            {
                var defaultData = new JournalData();
                SaveJournalData(defaultData);
                return defaultData;
            }
            var json = File.ReadAllText(JournalFilePath);
            return JsonSerializer.Deserialize<JournalData>(json);
        }

        public static void SaveJournalData(JournalData data)
        {
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(JournalFilePath, json);
        }
    }

    public class JournalData
    {
        public StudentGradeItem[] Grades { get; set; } = new StudentGradeItem[0];
        public LessonModel[] Lessons { get; set; } = new LessonModel[0];
        public ScheduleModel[] Schedule { get; set; } = new ScheduleModel[0];
    }
}
