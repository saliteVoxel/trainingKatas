using System;

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
                if (!numbers.Contains(","))
                {
                    return Int32.Parse(numbers);
                }

                int commaPosition = numbers.IndexOf(',');
                int firstNumber = Int32.Parse(numbers.Substring(0, commaPosition));
                int secondNumber = Int32.Parse(numbers.Substring(commaPosition + 1));
                return firstNumber + secondNumber;
                
            }

            
        }
    }
}