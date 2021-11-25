using System;
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
        public void CheckIfThreeIsFizz()
        {
            int listPosition = 2;
            string printedValue = "Fizz";
            int number = FizzbuzzCalculator.GenerateNumbers()[listPosition];
            Assert.Equal(printedValue, FizzbuzzCalculator.ConvertsValueToString(number));
        }
        
        [Fact]
        public void CheckIfFiveIsBuzz()
        {
            int listPosition = 4;
            string printedValue = "Buzz";
            int number = FizzbuzzCalculator.GenerateNumbers()[listPosition];
            Assert.Equal(printedValue, FizzbuzzCalculator.ConvertsValueToString(number));
        }
        
        [Fact]
        public void CheckIfSixIsFizz()
        {
            int listPosition = 5;
            string printedValue = "Fizz";
            int number = FizzbuzzCalculator.GenerateNumbers()[listPosition];
            Assert.Equal(printedValue, FizzbuzzCalculator.ConvertsValueToString(number));
        }
    }
}