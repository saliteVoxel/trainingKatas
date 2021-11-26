﻿using System;
using System.Collections.Generic;

namespace Fizzbuzz
{
    public class FizzbuzzCalculator
    {
        public static List<int> GenerateNumbers()
        {
            var printedNumbersList = new List<int>() {};
            for (int i = 1; i <= 100; i++)
            {
                printedNumbersList.Add(i);
            }

            return printedNumbersList;
        }
        public static string ConvertsValueToString(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
            {
                return "FizzBuzz";
            }
            if (number % 3 == 0 )
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