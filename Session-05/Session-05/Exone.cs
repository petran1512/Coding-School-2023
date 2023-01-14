using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ExersiceOne
    {
        //Write a C# program that reverses a given string (your name).
        public string Reverse()
        {
            Console.WriteLine("Enter a String: ");
            string name = Console.ReadLine();
            string reversed = string.Empty;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reversed += name[i];
            }
            return reversed;
        }
    }
}

