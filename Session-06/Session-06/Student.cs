﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Student : Person {
        public int RegistrationNumber { get; set; }
        public Course[] Courses { get; set; }

        public Student()
        {

        }

        public Student(int registrationnumber)
        {
            RegistrationNumber = registrationnumber;
        }

        public Student(int registrationnumber, Course[] courses)
        {
            RegistrationNumber = registrationnumber;
            Courses = courses;
        }


        public void Attend(string course,DateTime datetime)
        {

        }
        public void WriteExam(string course,DateTime dateTime)
        {

        }


    }
}
