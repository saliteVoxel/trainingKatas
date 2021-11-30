using System;
using Xunit;

namespace LeapYear.Tests
{
    public class LeapYearShould
    {
        [Theory]
        [InlineData(4, 4)]
        public void BeDividedByFour(int expectedResult, int number)
        {
            number = LeapYearCalculator.Calculate(number);
            Assert.Equal(expectedResult, number);
            
        }
    }
}



