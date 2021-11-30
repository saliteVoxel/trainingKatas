using System;
using Xunit;

namespace LeapYear.Tests
{
    public class LeapYearShould
    {
        
        [Theory]
        [InlineData(4)]
        [InlineData(8)]
        public void BeDividedByFourTrue(int number)
        {
            Assert.True(LeapYearCalculator.Calculate(number));
            
        }
        
        [Theory]
        [InlineData(400)]
        [InlineData(800)]
        public void BeDividedByFourHundrerTrue(int number)
        {
            Assert.True(LeapYearCalculator.Calculate(number));
            
        }
    }
}



