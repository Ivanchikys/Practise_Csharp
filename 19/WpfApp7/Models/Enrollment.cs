namespace TeacherJournal.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public CourseModel Course { get; set; }
        public int StudentId { get; set; }
        public StudentModel Student { get; set; }
        
        public List<GradeModel> Grades { get; set; } = new List<GradeModel>();
    }
}