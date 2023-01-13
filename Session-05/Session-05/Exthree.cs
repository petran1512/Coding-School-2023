using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ExersiceThree
    {
        /*Write a C# program that asks the user for an integer (n) and finds all
        the prime numbers from 1 to n.*/
        public string Prime()
        {
            Console.WriteLine("Enter a Integer: ");
            int  n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                int m = 2;
                int l = 1;
                while (m < i)
                {
                    if (i % m == 0)
                    {
                        l = 0;
                        break;
                    }
                    m++;
                }
                if (l == 1)
                {
                    return "Prime Number:" + i;
                }
            }
        }
    }
}
