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
        public void CheckNumbersInList(int listPosition, int printedNumber)
        {
            int number = FizzbuzzCalculator.PrintNumbers()[listPosition];
            Assert.Equal(printedNumber,number);
        }
    }
}