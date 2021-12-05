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
        [Fact]
        public void Return1For1()
        {
            int result = FibonacciCalculator.Calculate(1);
            Assert.Equal(1, result);
        }
        
        [Fact]
        public void Return2For2()
        {
            int result = FibonacciCalculator.Calculate(2);
            Assert.Equal(2, result);
        }
    }
}