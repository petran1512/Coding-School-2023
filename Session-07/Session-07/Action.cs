using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;



namespace Session_07
{
    public class Action
    {

        public enum ActionEnum
        {
            Convert,
            Uppercase,
            Reverse
        }

        public string ActioN(ActionEnum actionenum, decimal convert, string upper, string reverse)
        {

            string action = "";
            try
            {

                switch (actionenum)
                {
                    case ActionEnum.Convert:
                        action = ActionConvert(convert);
                        break;

                    case ActionEnum.Uppercase:
                        action = ActionUppercase(upper);
                        break;

                    case ActionEnum.Reverse:
                        action = ActionReverse(reverse);
                        break;

                    default:
                        Console.WriteLine("Error please select one of the above.");
                        break;
                }
                return action + " ";
            }

            catch (Exception ex)
            {
                throw;
            }
        }

        public string ActionConvert(decimal convert)
        {
            decimal action = 0;
            int n, i;
            int[] a = new int[10];
            Console.Write("Enter the number to convert: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            return action + "";
        }
 

        public string ActionUppercase(string upper)
        {
            string action = " ";
            return action;
        }

        public string ActionReverse(string reverse)
        {
            string action = " ";
            Console.Write(" Input the string : ");
            action = Console.ReadLine();
            Console.Write(" The reverse of the string is : ");
            Console.Write(action);
            Console.ReadKey();
             Console.Write("\n"); 
        
            if (action.Length > 0)
                return action[action.Length - 1] +  (action.Substring(0, action.Length - 1));
            else
                return action;
        }
    }
}
