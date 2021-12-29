using System;
using Xunit;

namespace MarsRoverSMS.Tests
{
    public class RoverShould
    {
        [Fact]
        public void BeAtPositionZeroOne()
        {
            Rover rover = new("0,0");
            
            //Rover.MoveForward
            
            Assert.Equal("0,1", rover.Position());
        }
    }
}