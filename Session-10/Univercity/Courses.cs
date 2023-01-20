namespace UniversityClasses
{
    public class Courses : Students
    {
        public Guid CourseID { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }
    }
}