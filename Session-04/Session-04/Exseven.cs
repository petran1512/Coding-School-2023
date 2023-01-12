using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class ExersiceSeven
    {
        //Write a C# method to convert from celsius degrees to Kelvin and Fahrenheit.
        public string convertion()
        {
            double c = 30;
            double k = 273.15 + c;
            double f = 1.8 * c + 32;
            return "Celsius are " + c + " degrees.\n" + "Celsius to Kelvin are " + k + " degrees.\n" + 
                "and Celsius to Fahrenheit are " + f + " degrees.";
        }
    }
}
