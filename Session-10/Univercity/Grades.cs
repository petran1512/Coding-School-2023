namespace UniversityClasses
{
    public class Grades : Students
    {
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int Grade { get; set; }
    }
}