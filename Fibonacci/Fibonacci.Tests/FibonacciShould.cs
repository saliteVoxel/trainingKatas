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

        [Theory]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(11, 89)]
        public void CheckFibonacciNumbers(int number, int result)
        {
            int expectedResult = FibonacciCalculator.Calculate(number);
            Assert.Equal(result, expectedResult);
        }
    }
}