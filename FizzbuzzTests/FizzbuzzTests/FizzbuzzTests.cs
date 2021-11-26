using System;
using System.Runtime.InteropServices;
using Fizzbuzz;
using Xunit;

namespace FizzbuzzTests
{
    public class CheckIfListPrintsCorrectNumbers 
    {
        [Theory]
        [InlineData(0,1)]
        [InlineData(1,2)]
        [InlineData(2,3)]
        [InlineData(3,4)]
        [InlineData(99,100)]
        public void CheckNumbersInList(int listPosition, int printedNumber)
        {
            int number = FizzbuzzCalculator.GenerateNumbers()[listPosition];
            Assert.Equal(printedNumber,number);
        }
        
        [Fact]
        public void CheckIfOneIsOne()
        {
            int listPosition = 0;
            string printedValue = "1";
            int number = FizzbuzzCalculator.GenerateNumbers()[listPosition];
            Assert.Equal(printedValue, FizzbuzzCalculator.ConvertsValueToString(number));
        }

        [Theory]
        [InlineData(2, "Fizz")]
        [InlineData(5, "Fizz")]
        public void CheckFizz( int listPosition, string printedValue)
        {
            int number = FizzbuzzCalculator.GenerateNumbers()[listPosition];
            Assert.Equal(printedValue, FizzbuzzCalculator.ConvertsValueToString(number));
        }
        
        [Theory]
        [InlineData(4, "Buzz")]
        [InlineData(9, "Buzz")]
        public void CheckBuzz( int listPosition, string printedValue)
        {
            int number = FizzbuzzCalculator.GenerateNumbers()[listPosition];
            Assert.Equal(printedValue, FizzbuzzCalculator.ConvertsValueToString(number));
        }
        
        [Theory]
        [InlineData(14, "FizzBuzz")]
        [InlineData(29, "FizzBuzz")]
        public void CheckFizzBuzz(int listPosition, string printedValue)
        {
            int number = FizzbuzzCalculator.GenerateNumbers()[listPosition];
            Assert.Equal(printedValue, FizzbuzzCalculator.ConvertsValueToString(number));
        }
    }
}