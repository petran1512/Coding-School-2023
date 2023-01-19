using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Session_07
{


    public class StringManipulator
    {

        public string Text { get; set; }

        public virtual string Manipulate()
        {

            return string.Empty;
        }

    }

    public class StringConvert : StringManipulator
    {


        public override string Manipulate()
        {

            // “Convert” you must check if the Input is a decimal number and convert it to binary.
            // ...
            int us ,i;
            int[] a = new int[10];
            Console.Write("Enter the number to convert: ");
            us = int.Parse(Console.ReadLine());
            for (i = 0; us > 0; i++)
            {
                a[i] = us % 2;
                us = us / 2;
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            return us + "" ;
        }
    }


    public class StringReverse : StringManipulator
    {

        public override string Manipulate()
        {
            //Reverse” you must check if the Input is a string and reverse it.
            Console.Write(" Input the string : ");
            string us = Console.ReadLine();
            Console.Write(" The reverse of the string is : ");
            Console.Write(us);
            Console.ReadKey();
            Console.Write("\n");

            if (us.Length > 0)
                return us[us.Length - 1] + (us.Substring(0, us.Length - 1));
            else
                return us;

            //return us;
        }

    }

    public class StringUppercase : StringManipulator
    {

        public override string Manipulate()
        {
            //Uppercase” you must check if the Input is a string and has more than
            //one words(separated by a space), then find the longest word in the
            //Input string and convert it to uppercase
            Console.Write(" Input the string : ");
            string us = Console.ReadLine();
            String result = us.ToUpper();
            Console.WriteLine($"Original String  : {us}");
            Console.WriteLine($"Uppercase String : {result}");
            
            return us;
        }
    }

}