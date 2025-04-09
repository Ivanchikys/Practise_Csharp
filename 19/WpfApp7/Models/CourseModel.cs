namespace TeacherJournal.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}