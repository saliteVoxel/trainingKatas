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
        [InlineData(2, "Fizz")]
        [InlineData(5, "Fizz")]
        [InlineData(8, "Fizz")]
     
        public void CheckIfThreeModulesAreFizz(int listPosition, string printedValue)
        {
            int number = FizzBuzzGenerator.GenerateNumbers()[listPosition];
            
            Assert.Equal(printedValue, FizzBuzzGenerator.StringGenerator(number));
        }
        
        [Theory]
        [InlineData(9, "Buzz")]
        [InlineData(19, "Buzz")]
        
     
        public void CheckIfFiveModulesAreBuzz(int listPosition, string printedValue)
        {
            int number = FizzBuzzGenerator.GenerateNumbers()[listPosition];
            
            Assert.Equal(printedValue, FizzBuzzGenerator.StringGenerator(number));
        }
        
        
        [Theory]
        [InlineData(14, "FizzBuzz")]
        [InlineData(29, "FizzBuzz")]

        public void CheckIfFiveAndThreeModulesAreFizzBuzz(int listPosition, string printedValue)
        {
            int number = FizzBuzzGenerator.GenerateNumbers()[listPosition];
            
            Assert.Equal(printedValue, FizzBuzzGenerator.StringGenerator(number));
        }
        
    
        
      
        
        
    }

}