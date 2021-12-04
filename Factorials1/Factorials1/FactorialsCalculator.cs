using System;

namespace Factorials1
{
    public class FactorialsCalculator
    {
        public static int Calculate(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number < 2)
            {
                return 1;
            }

            int index = number - 1;
            int result = number;
            while (index >= 2)
            {
                result *= index;
                index--;
            }
            return result;
        }
    }
}