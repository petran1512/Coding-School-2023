using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class University : Institute {
        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }
        public Grade[] Grades { get; set; }
        public Schedule[]? ScheduledCourse { get; set; }




        public void GetStudents() {

        }
        public void GetCourses() {

        }
        public void GetGrades() {

        }
        public void SetSchedule(int courseID,int ProfessorID, DateTime datetime) {

        }
    }
}
