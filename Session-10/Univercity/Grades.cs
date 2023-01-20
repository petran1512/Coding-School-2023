namespace UniversityClasses
{
    public class Grades : Students
    {
        public Guid StudenID { get; set; }
        public Guid CourseID { get; set; }
        //change from class diagram: Grade property can't be the same as class name.
        public int Grade { get; set; }
    }
}