using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        public static int Sum(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            
            List<char> delimiterChars = new List<char>{ ',','\n' };
            if (numbers.Substring(0,2) == "//")
            {
                char specialCharacter = Char.Parse(numbers.Substring(2, 1));
                delimiterChars.Add(specialCharacter);
                int endOfSpecialCharacter = numbers.IndexOf('\n');
                numbers = numbers.Substring(endOfSpecialCharacter + 1);
            }
            

            string[] numbersToSum = numbers.Split(delimiterChars.ToArray());
            int[] numbersToSumInt = Array.ConvertAll(numbersToSum, number =>
            {
                int numberToInt = int.Parse(number);
                if (numberToInt < 0)
                {
                    throw new ArgumentException("Negative numbers are not allowed");
                }
                return numberToInt;
            });
            
            return numbersToSumInt.Sum();
            
            

        }
    }
}