using System;
using Xunit;

namespace Fibonacci.Tests
{
    public class FibonacciShould
    {
        [Fact]
        public void Return0For0()
        {
            int result = FibonacciCalculator.Calculate(0);
            Assert.Equal(0, result);
        }
    }
}