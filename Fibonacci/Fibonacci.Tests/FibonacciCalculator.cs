namespace Fibonacci.Tests
{
    public class FibonacciCalculator
    {
        public static int Calculate(int number)
        {
            if (number == 0)
                return 0;
            if (number == 1)
                return 1;
            if (number == 2)
                return 2;
            return number;
            
        }
    }
}