using Microsoft.EntityFrameworkCore;
using TeacherJournal.Models;

namespace TeacherJournal.Data
{
    public class JournalContext : DbContext
    {
        public DbSet<CourseModel> Courses { get; set; }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<GradeModel> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=journal.db");
        }
    }
}