namespace UniversityClasses
{
    public class Schedules : Students
    {
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public string Callendar { get; set; }
    }
}