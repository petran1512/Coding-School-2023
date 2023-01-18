using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Session_07
{

    public enum ActionEnum
    {
        Convert,
        Uppercase,
        Reverse
    }

    public class ActionResolver
    {

        //props
        public MessageLogger Logger { get; set; }

        //consts
        public ActionResolver()
        {

        }
        public ActionResolver(MessageLogger logger)
        {
            Logger = new MessageLogger();
        }

        //meths
        public ActionResponse Execute(ActionRequest request)
        {


            ActionResponse response = new ActionResponse();
            response.ResponseID = Guid.NewGuid();
            response.RequestID = request.RequestID;

            Log("EXECUTION START");

            try
            {

                switch (request.Action)
                {
                    case ActionEnum.Convert:
                        Log("CONVERT");
                        response.Output = Convert(request.Input);
                        break;

                    case ActionEnum.Uppercase:
                        Log("UPPERCASE");
                        response.Output = Uppercase(request.Input);
                        break;

                    case ActionEnum.Reverse:
                        Log("REVERSE");
                        response.Output = Reverse(request.Input);
                        break;

                    default:
                        Console.WriteLine("Error please select one of the above.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);

            }
            finally
            {
                Log("EXECUTION END");
            }


            return response;
        }



        private void Log(string text)
        {

            Logger.Write(new Message("------------"));

            Message message = new Message(text);
            Logger.Write(message);
        }

        //public string Convert(string input)
        //{

        //    StringConvert convert = new StringConvert();
        //    convert.Text = input;

        //    return convert.Manipulate();
        //}

        public string Uppercase(string input)
        {
            // “Uppercase” you must check if the Input is a string and has more than
            // one words(separated by a space), then find the longest word in the
            // Input string and convert it to uppercase.



            return input.ToUpper();
        }

        public string Reverse(string input)
        {
            // “Reverse” you must check if the Input is a string and reverse it.

            return string.Empty;

        }
        //public string ActionReverse(string reverse)
        //{
        //    string action = " ";
        //    Console.Write(" Input the string : ");
        //    action = Console.ReadLine();
        //    Console.Write(" The reverse of the string is : ");
        //    Console.Write(action);
        //    Console.ReadKey();
        //    Console.Write("\n");

        //    if (action.Length > 0)
        //        return action[action.Length - 1] + (action.Substring(0, action.Length - 1));
        //    else
        //        return action;
        //}

        //public string ActionConvert(decimal convert)
        //{
        //    decimal action = 0;
        //    int n, i;
        //    int[] a = new int[10];
        //    Console.Write("Enter the number to convert: ");
        //    n = int.Parse(Console.ReadLine());
        //    for (i = 0; n > 0; i++)
        //    {
        //        a[i] = n % 2;
        //        n = n / 2;
        //    }
        //    Console.Write("Binary of the given number= ");
        //    for (i = i - 1; i >= 0; i--)
        //    {
        //        Console.Write(a[i]);
        //    }
        //    return action + "";

    }
}
