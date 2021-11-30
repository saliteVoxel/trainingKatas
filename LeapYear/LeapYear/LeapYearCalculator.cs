using System;

namespace LeapYear
{
    public class LeapYearCalculator
    {
        public static bool Calculate(int number)
        {
            if (number % 100 == 0 && number % 400 != 0)
            {
                return false;
            }
            if (number % 100 == 0 && number % 400 != 0)
            {
                return false;
            }
            return number % 4 == 0;
        }
    }
}