using System;
using Xunit;

namespace StringCalculator.Tests
{
    public class StringCalculatorShould
    {
        [Fact]
        public void ReturnZeroForAnEmptyString()
        {
            int actual = Calculator.Sum("");
            Assert.Equal(0, actual);
        }

        [Theory]
        [InlineData("0,1", 1)]
        [InlineData("0,2", 2)]
        [InlineData("0,3", 3)]
        public void ReturnZeroPlusOtherNumber(string numbers, int expected)
        {
            Assert.Equal(expected, Calculator.Sum(numbers));
            
        }
        
        [Theory]
        [InlineData("1,1", 2)]
        [InlineData("1,2", 3)]
        [InlineData("1,3", 4)]
        public void ReturnOnePlusOtherNumber(string numbers, int expected)
        {
            Assert.Equal(expected, Calculator.Sum(numbers));
            
        }
        [Theory]
        [InlineData("1,1,1", 3)]
        [InlineData("1,1,2", 4)]
        [InlineData("1,1,3", 5)]
        [InlineData("1,1,1,3", 6)]
        [InlineData("1,1,1,1, 3", 7)]
        public void ReturnTheSumOfMultipleNumbers(string numbers, int expected)
        {
            Assert.Equal(expected, Calculator.Sum(numbers));
            
        }
        
        [Theory]
        [InlineData("1\n1\n1", 3)]
    
        public void AcceptNextLineSeparator(string numbers, int expected)
        {
            Assert.Equal(expected, Calculator.Sum(numbers));
            
        }
        
        [Theory]
        [InlineData("//;\n1;2", 3)]
    
        public void AcceptMultipleSeparators(string numbers, int expected)
        {
            Assert.Equal(expected, Calculator.Sum(numbers));
            
        }

    }
}