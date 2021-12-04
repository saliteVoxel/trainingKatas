using System;
using System.Runtime.InteropServices;
using Xunit;

namespace Factorials1.Tests
{
    public class FactorialsShould
    {
        [Theory]
        [InlineData(0,1)]
        public void CheckIfFactorialsAreCorrect(int expected, int number)
        {
            int result = FactorialsCalculator.Calculate(number);
            
            Assert.Equal(expected, result);
        }
    }
}