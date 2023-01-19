namespace CalculatorLibrary
{
    public class Raise_to_Power
    {
        public decimal Do(decimal? a, decimal? b)
        {
            decimal ret = 0;

            if (a != null || b != null)
            {
                ret = (decimal)Math.Pow((double)a, 2);
            }
            return ret;
        }
    }
}