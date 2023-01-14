using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ExThree
    {
        /*Write a C# program that asks the user for an integer (n) and finds all the prime numbers from 1 to n.*/

        public string Prime()
        {
            Console.WriteLine("Enter a Integer Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool primen = true;
            int i, j;
            Console.WriteLine("The Prime Numbers of {0} are : ", n);
            for (i = 2; i < n; i++)
            {
                for (j = 2; j < n; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        primen = false;
                        break;
                    }
                }
                if (primen)
                {
                    Console.Write(" " + i);
                }
                primen = true;
            }
            return " " + n;
        }
    }
}
