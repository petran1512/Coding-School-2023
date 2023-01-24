namespace UniversityClasses
{
    public class Students
    {
        public enum GenderEnum { Male, Female, Other }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string University { get; set; }
        public bool Undergraduate { get; set; }
        public int Age { get; set; }    
        public GenderEnum Gender { get; set; }
        public Guid UniversityID { get; set; }



        public Students()
        {
            ID = Guid.NewGuid();
        }
    }
}