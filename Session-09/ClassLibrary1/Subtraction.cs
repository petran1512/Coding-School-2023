namespace CalculatorLibrary
{
    public class Subtraction
    {
        public decimal Do(decimal? a, decimal? b)
        {
            decimal ret = 0;

            if (a != null || b != null)
            {
                ret = a.Value - b.Value;
            }
            return ret;
        }
    }
}
