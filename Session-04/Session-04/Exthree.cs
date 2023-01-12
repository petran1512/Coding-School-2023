using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class ExersiceThree
    {
        /*Write a C# method to print the result of the specified operations:
         • −1 + 5 × 6
         • 38 + 5 𝑚𝑜𝑑 7
         • 14 + ((−3 × 6) / 7 )
         • 2 + (13/6) × 6 + √7
         • ((6^4) + (5^7)) / (9 𝑚𝑜𝑑 4)*/
        public string operations()
        {
            int fo = -1 + (5 * 6);
            float so = 38 + (5 % 7);
            float to = 14 + ((-3 * 6) / 7);
            double fro = 2 + ((13 / 6) * 6) + (Math.Sqrt(7));
            double ffo = ((Math.Pow(6 , 4) + (Math.Pow(5 , 7))) / (9 % 4));
            return "First operation:" + fo + "\nSecond operation:" + so + "\nThird operation:" + to +
                "\nFourth operation:" + fro + "\nFifth operation:" + ffo ;
        }
    }
}