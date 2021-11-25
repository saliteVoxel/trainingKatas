using System;
using System.Collections.Generic;

namespace Fizzbuzz
{
    public class FizzbuzzCalculator
    {
        public static List<int> PrintNumbers()
        {
            var printedNumbersList = new List<int>() {};
            for (int i = 1; i < 100; i++)
            {
                printedNumbersList.Add(i);
            }

            return printedNumbersList;
        }
    }
}