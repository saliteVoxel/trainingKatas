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
        public void CheckIfThreeIsFizz(int listPosition, string printedValue)
        {
            int number = FizzBuzzGenerator.GenerateNumbers()[listPosition];
            
            Assert.Equal(printedValue, FizzBuzzGenerator.StringGenerator(number));
        }
        
        
    }

}