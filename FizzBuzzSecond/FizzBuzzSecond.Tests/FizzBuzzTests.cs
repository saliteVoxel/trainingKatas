using System;
using Xunit;

namespace FizzBuzzSecond.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void CheckIfThereAreNumbersInTheList()
        {
            int printedNumber = 1;
            int listPosition = 0;
            int number = FizzBuzzGenerator.GenerateNumbers()[listPosition];
            
            Assert.Equal(printedNumber, number);
        }
        
        [Theory]
        [InlineData(4, "Fizz")]
        [InlineData(7, "Fizz")]
        [InlineData(10, "Fizz")]
        [InlineData(16, "Fizz")]
        public void CheckIfThreeModulesAreFizz(int listPosition, string printedValue)
        {
            int number = FizzBuzzGenerator.GenerateNumbers()[listPosition];
            
            Assert.Equal(printedValue, FizzBuzzGenerator.StringGenerator(number));
        }
        
        [Theory]
        [InlineData(6, "Buzz")]
        [InlineData(11, "Buzz")]
        [InlineData(16, "Buzz")]
        [InlineData(21, "Buzz")]
        public void CheckIfFiveModulesAreBuzz(int listPosition, string printedValue)
        {
            int number = FizzBuzzGenerator.GenerateNumbers()[listPosition];
            
            Assert.Equal(printedValue, FizzBuzzGenerator.StringGenerator(number));
        }
        
        
    }

}