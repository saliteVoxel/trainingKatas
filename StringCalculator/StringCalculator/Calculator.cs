using System;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        public static int Sum(string numbers)
        {
            {
                if (string.IsNullOrEmpty(numbers))
                {
                    return 0;
                }

                string[] numbersToSum = numbers.Split(",");
                int[] numbersToSumInt = Array.ConvertAll(numbersToSum, number => int.Parse(number));
                return numbersToSumInt.Sum();
                
            }

            
        }
    }
}