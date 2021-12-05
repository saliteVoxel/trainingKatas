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
            return number;
            
        }
    }
}