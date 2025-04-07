using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TeacherJournal.Models;

namespace TeacherJournal.Services
{
    public static class JournalService
    {
        public static async Task<ObservableCollection<StudentGradeItem>> LoadStudentGradesAsync(CourseModel course)
        {
            await Task.Delay(3000);
            var list = new ObservableCollection<StudentGradeItem>();

            if (course != null)
            {
                if (course.CourseName == "КПиЯП")
                {
                    list.Add(new StudentGradeItem { FullName = "Ерошеня И.С.", Grade = "9", Comment = "Молочинка", IsPresent = true, CourseName = "КПиЯП" });
                    list.Add(new StudentGradeItem { FullName = "Джангиров П.С.", Grade = "8", Comment = "Хороший работяга", IsPresent = true, CourseName = "КПиЯП" });
                }
                else if (course.CourseName == "Практика")
                {
                    list.Add(new StudentGradeItem { FullName = "Ерошеня И.С.", Grade = "10", Comment = "Отлично", IsPresent = true, CourseName = "Практика" });
                    list.Add(new StudentGradeItem { FullName = "Джангиров П.С.", Grade = "7", Comment = "Хорошо", IsPresent = false, CourseName = "Практика" });
                }
                else if (course.CourseName == "ТПО")
                {
                    list.Add(new StudentGradeItem { FullName = "Ерошеня И.С.", Grade = "8", Comment = "Удовлетворительно", IsPresent = false, CourseName = "ТПО" });
                    list.Add(new StudentGradeItem { FullName = "Джангиров П.С.", Grade = "6", Comment = "Плохо", IsPresent = false, CourseName = "ТПО" });
                }
            }
            return list;
        }
    }
}
