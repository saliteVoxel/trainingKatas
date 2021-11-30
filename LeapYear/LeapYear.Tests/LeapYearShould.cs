using System;
using Xunit;

namespace LeapYear.Tests
{
    public class LeapYearShould
    {
        
        [Theory]
        [InlineData(4)]
        public void BeDividedByFourTrue(int number)
        {
            Assert.True(LeapYearCalculator.Calculate(number));
            
        }
    }
}



