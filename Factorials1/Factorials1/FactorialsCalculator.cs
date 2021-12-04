namespace Factorials1
{
    public class FactorialsCalculator
    {
        public static int Calculate(int number)
        {
            if (number < 2)
            {
                return 1;
            }

            int index = number - 1;
            int result = number;
            while (number >= 2)
            {
                result = number * index;
                index--;
            }
            return result;
        }
    }
}