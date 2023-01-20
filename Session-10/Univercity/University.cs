using System.Diagnostics;
using UniversityClasses;

namespace University
{
        public class University
    {
            public List<Students> Students { get; set; }
            public List<Courses> Courses { get; set; }
            public List<Grades> Grades { get; set; }
            public List<Schedules> ScheduledCourses { get; set; }

            public University()
            {

            }

            public University(List<Students> students)
            {
                Students = students;
            }

            public University(List<Students> students, List<Courses> courses)
            {
                Students = students;
                Courses = courses;
            }

            public University(List<Students> students, List<Courses> courses, List<Grades> grades)
            {
                Students = students;
                Courses = courses;
                Grades = grades;
            }

            public University(List<Students> students, List<Courses> courses, List<Grades> grades, List<Schedules> scheduledcourses)
            {
                Students = students;
                Courses = courses;
                Grades = grades;
                ScheduledCourses = scheduledcourses;

            }

            //public void GetStudents()
            //{

            //}
            //public void GetCourses()
            //{

            //}
            //public void GetGrades()
            //{

            //}
            //public void SetSchedules(int courseID, int ProfessorID, DateTime datetime)
            //{

            //}
    }
}

