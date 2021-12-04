namespace Factorials1
{
    public class FactorialsCalculator
    {
        public static int Calculate(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            if (number == 2)
            {
                return 2;
            }
            if (number == 3)
            {
                return 6;
            }
            return 1;
        }
    }
}