using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ExersiceFour
    {
        /*Write a C# program to multiply all values from Array1 with all values
        from Array2 and display the results in a new Array.
            • Array1: [2, 4, 9, 12]
            • Array2: [1, 3, 7, 10].*/
        public string Multiply() {
            int Array1 = [2, 4, 9, 12];
            int Array2 = [2, 4, 9, 12];
            int mult = 1;
            foreach (int i in Array1)
                mult = mult * i;
            Console.WriteLine(mult);
        }
    }
}
