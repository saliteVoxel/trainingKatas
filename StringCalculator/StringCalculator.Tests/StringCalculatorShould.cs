using System;
using Xunit;

namespace StringCalculator.Tests
{
    public class StringCalculatorShould
    {
        [Fact]
        public void ReturnZeroForAnEmptyString()
        {
            int actual = Calculator.Sum(" ");
            Assert.Equal(0, actual);
        }
    }
}