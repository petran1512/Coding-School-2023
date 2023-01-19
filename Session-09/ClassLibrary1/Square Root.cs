namespace CalculatorLibrary
{
    public class Square_Root
    {
        public decimal Do(decimal? a)
        {
            decimal ret = 0;

            if (a != null)
            {
                ret = (decimal)Math.Sqrt((double)a); ;
            }
            return ret;
        }
    }
}
