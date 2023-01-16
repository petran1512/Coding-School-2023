using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ExFour
    {
        /*Write a C# program to multiply all values from Array1 with all values from Array2 and display the results in a new Array. 
         * • Array1: [2, 4, 9, 12] 
         * • Array2: [1, 3, 7, 10]*/
        public int Multi()
        {
            int[][] r =
            {
                new int []{2,4,9,12},
                new int []{1,3,7,10}
            };

            for (int i = 0; i < r[0].Length; i++)
            {
                for (int j = 0; j < r[1].Length; j++)
                    return Console.Write(r[0][i] * r[1][j] + " ");
            }
            //return 0;
        }
    }
}

