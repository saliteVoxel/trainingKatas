using System;
using System.Collections.Generic;

namespace FizzBuzzSecond
{
    
    public class FizzBuzzGenerator
    {
        public static List<int> GenerateNumbers()
        {
            var printedNumbers = new List<int>() {};
                printedNumbers.Add(1);
                return printedNumbers;
            
        }
        
        public static string StringGenerator(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";   
            }

            return number.ToString();
        }
    }
}
