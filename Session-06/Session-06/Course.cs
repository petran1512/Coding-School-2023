using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Course {
        public Guid ID { get; set; }
        public String Code { get; set; }
        public String Subject { get; set; }

        public Course()
        {

        }
        public Course(Guid id)
        {
            ID = id;
        }

        public Course(Guid id, String code)
        {
            ID = id;
            Code = code;
        }

        public Course(Guid id, String code, String subject)
        {
            ID = id;
            Code = code;
            Subject = subject;
        }



    }
}
