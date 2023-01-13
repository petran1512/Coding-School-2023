using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
            //int num, i, ctr, stno, enno;
            Console.WriteLine("Enter a Integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++) {
                if (n % i == 0) {
                    Console.WriteLine("Prime Number is:" + n);
                    break;
                }
            }
        }
    }
}





//        {
//            static bool isPrime(int n)
//            {

                
//                if (n <= 1)
//                    return false;

                
//                for (int i = 2; i < n; i++)
//                    if (n % i == 0)
//                        return false;

//                return true;
//            }

            
//            static void printPrime(int n)
//            {
//                for (int i = 2; i <= n; i++)
//                {
//                    if (isPrime(i))
//                        Console.Write(i + " ");
//                }
//            }

            
//            public static void Main()
//            {
//                int n = 7;
//                printPrime(n);
//            }
//        }
//    }
//}


//            Console.WriteLine("Enter a Integer: ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            int final = 0;
//            for (int i = 2; i <= n; i++)
//            {
//                int m = 2;
//                int l = 1;
//                while (m < i)
//                {
//                    if (i % m == 0)
//                    {
//                        l = 0;
//                        break;
//                    }
//                    m++;
//                }
//                if (l == 1)
//                {
//                    final = i;
//                    return "Prime Number:" + final;
//                }
//            }
//            return "Prime Number:" + final;
//        }
//    }
//}
