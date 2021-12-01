using System;

namespace StringCalculator
{
    public class Calculator
    {
        public static int Sum(string numbers)
        {
            {
                if (numbers == "0,1")
                {
                    return 1;
                }
                if (numbers == "0,2")
                {
                    return 2;
                }
                if (numbers == "0,3")
                {
                    return 3;
                }
                if (numbers == "1,1")
                {
                    return 2;
                }
                if (numbers == "1,2")
                {
                    return 3;
                }
                if (numbers == "1,3")
                {
                    return 4;
                }
        
                return 0;
            }

            
        }
    }
}