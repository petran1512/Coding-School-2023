using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_06
{
    public class Grade
    {

        public Guid ID { get; set; }
        public Guid StudenID { get; set; }
        public Guid CourseID { get; set; }
        //change from class diagram: Grade property can't be the same as class name.
        public int GradeText { get; set; }

        public Grade()
        {

        }

        public Grade(Guid id)
        {
            ID = id;
        }

        public Grade(Guid id, Guid studenid)
        {
            ID = id;
            StudenID = studenid;
        }

        public Grade(Guid id, Guid studenid, Guid courseid)
        {
            ID = id;
            StudenID = studenid;
            CourseID = courseid;
        }

        public Grade(Guid id, Guid studenid, Guid courseid, int gradetext)
        {
            ID = id;
            StudenID = studenid;
            CourseID = courseid;
            GradeText = gradetext;


        }
    }
}
