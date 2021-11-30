using System;

namespace LeapYear
{
    public class LeapYearCalculator
    {
        public static bool Calculate(int number)
        {
            return number % 4 == 0;

        }
    }
}