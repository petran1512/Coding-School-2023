using System.Diagnostics;
using UniversityClasses;

namespace University
{
        public class University
    {
            public List<Student> Students { get; set; }
            public List<Course> Courses { get; set; }
            public List<Grade> Grades { get; set; }
            public List<Schedule> ScheduledCourses { get; set; }

            public University()
            {

            }

            public University(List<Student> students)
            {
                Students = students;
            }

            public University(List<Student> students, List<Course> courses)
            {
                Students = students;
                Courses = courses;
            }

            public University(List<Student> students, List<Course> courses, List<Grade> grades)
            {
                Students = students;
                Courses = courses;
                Grades = grades;
            }

            public University(List<Student> students, List<Course> courses, List<Grade> grades, List<Schedule> scheduledcourses)
            {
                Students = students;
                Courses = courses;
                Grades = grades;
                ScheduledCourses = scheduledcourses;

            }

            public void GetStudents()
            {

            }
            public void GetCourses()
            {

            }
            public void GetGrades()
            {

            }
            public void SetSchedule(int courseID, int ProfessorID, DateTime datetime)
            {

            }
    }
}

