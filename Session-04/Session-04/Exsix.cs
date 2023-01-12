using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;


namespace Session_04
{
    public class ExersiceSix
    {
        //Write exersice #5 using .Net Libraries..
        public string secondswithNetLib()
        {
            TimeSpan time = TimeSpan.FromSeconds(45678);
            //float time = 45678;
            //float m = 45678 / 60;
            //float h = m / 60;
            //float d = h / 24;
            //float y = d / 365;
            return "Minutes:" + time.TotalMinutes + "\nHours:" + time.TotalHours + 
                "\nDays:" + time.TotalDays + "\nYears:" + time.TotalDays/365;
        }
    }
}