using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_05
{
    public class ExersiceTwo
    {
        /*Write a C# program that asks the user for an integer (n) and gives them
        the possibility to choose between computing the sum and computing the product of 1,...,n.*/
        public int Choose()
        {
            int sum = 0;
            int product = 1;
            Console.WriteLine("Enter a Integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1 for computhing sum or 2 for computing product: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                for (int i = 0; i <= n; i++)
                {
                    sum += i;
                }
            }
            if (choice == 2) {
                for (int i = 1; i <= n; i++)
                {
                    product *= i;
                }
                //return product;
            }
            return sum;
            return product;
        }
    }
}
