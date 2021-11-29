using System;
using System.Collections.Generic;

namespace FizzBuzzSecond
{
    
    public class FizzBuzzGenerator
    {
        public static List<int> GenerateNumbers()
        {
            var printedNumbers = new List<int>() {};
            for (int i = 1; i < 100; i++)
            {
                printedNumbers.Add(i);
            }
                return printedNumbers;

        }
        
        public static string StringGenerator(int number)
        {
            if ((number % 3 == 0)&&(number % 5 == 0))
            {
                return "FizzBuzz";   
            }
            if (number % 3 == 0)
            {
                return "Fizz";   
            }
            if (number % 5 == 0)
            {
                return "Buzz";   
            }

            return number.ToString();
        }
        
    }
}
