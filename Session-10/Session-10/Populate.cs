using System.Diagnostics;
using UniversityClasses;
namespace Populate
{
    public class PopulateStudent
    {
        public PopulateStudent()
        {

        }

           public List<Students> PopulateStudents()
        {
            List<Students>students = new List<Students>();

            Students student1 = new Students()
            {
                Name = "Peter",
                Surname = "Raisis",
                University = "Unifercity of Athens",
                Undergraduate = true,
                Age = 22,
                Gender = Students.GenderEnum.Male,
            };
            students.Add(student1);
            return students;
        }
    }
}
