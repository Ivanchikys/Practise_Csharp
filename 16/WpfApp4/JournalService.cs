using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherJournal
{
    public class JournalService
    {
        public async Task<List<GradeModel>> LoadGradesAsync()
        {
            await Task.Delay(3000);
            return new List<GradeModel>
        {
            new GradeModel
            {
                Student = new StudentModel { Id = 1, FullName = "Иванов И.И." },
                Grade = "5",
                Comment = "Отлично",
                IsPresent = true
            },
            new GradeModel
            {
                Student = new StudentModel { Id = 2, FullName = "Сидорова А.А." },
                Grade = "4",
                Comment = "Хорошо",
                IsPresent = false
            }
        };
        }

        public List<CourseModel> LoadCourses()
        {
            return new List<CourseModel>
        {
            new CourseModel { Id = 1, Name = "КПиЯП" },
            new CourseModel { Id = 2, Name = "ТПО" }
        };
        }
    }
}
