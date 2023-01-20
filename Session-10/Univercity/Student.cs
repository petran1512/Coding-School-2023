namespace UniversityClasses
{
    public class Students
    {
        public Students()
        {
            ID = Guid.NewGuid();
        }
        public enum GenderEnum { Male, Female, Other }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string University { get; set; }
        public bool Undergraduate { get; set; }
        public int Age { get; set; }    
        public GenderEnum Gender { get; set; }

    }
}