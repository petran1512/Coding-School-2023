namespace UniversityClasses
{
    public class Student
    {
        public enum GenderEnum { Male, Female, Other }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string University { get; set; }
        public bool Undergraduate { get; set; }
        public int Age { get; set; }    
        public GenderEnum Gender { get; set; }

    }
}