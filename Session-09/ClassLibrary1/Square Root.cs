using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorLibrary
{
    public class Square_Root
    {
        public decimal Do(decimal? a, decimal? b)
        {
            decimal ret = 0;

            if (a != null || b != null)
            {
                ret = (decimal)Math.Sqrt((double)a); ;
            }
            return ret;
        }
    }
}
