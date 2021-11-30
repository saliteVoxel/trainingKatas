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
        public void BeDividedByFourHundredTrue(int number)
        {
            Assert.True(LeapYearCalculator.Calculate(number));
            
        }
        
        [Theory]
        [InlineData(600)]
        [InlineData(900)]
        public void BeDividedByOneHundredButNotByFourHundred(int number)
        {
            Assert.False(LeapYearCalculator.Calculate(number));
            
        }
    }
}



