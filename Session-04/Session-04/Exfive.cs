using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class ExersiceFive
    {
        /*Write a C# method that takes an integer representing seconds (for
        example 45678) and converts it to:
        • Minutes
        • Hours
        • Days
        • Years.*/
        public string seconds()
        {
            double m = 45678 / 60;
            double h = m / 60 ;
            double d = h / 24 ;
            double y = d / 365 ;
            return "Minutes:" + m + "\nHours:" + h + "\nDays:" + d + "\nYears:" + y;
        }
    }
}