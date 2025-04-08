using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using TeacherJournal.Models;

namespace TeacherJournal.Services
{
    public static class JournalService
    {
        public static async Task<ObservableCollection<StudentGradeItem>> LoadStudentGradesAsync(CourseModel course)
        {
            await Task.Delay(1000);

            var journalData = DataStorageService.LoadJournalData();

            if (journalData?.Grades == null)
                return new ObservableCollection<StudentGradeItem>();

            var filteredGrades = journalData.Grades
                .Where(g => g.CourseName == course.CourseName)
                .ToList();

            return new ObservableCollection<StudentGradeItem>(filteredGrades);
        }
    }
}
