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

        [Theory]
        [InlineData("0,1", 1)]
        public void ReturnZeroPlusOtherNumber(string numbers, int expected)
        {
            Assert.Equal(expected, Calculator.Sum(numbers));
            
        }
    }
}