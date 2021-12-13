using System;
using MarsRoverGuided.Tests;
using Xunit;

namespace MarsRoverGuided.Tests
{
    public class MarsRoverShould
    {
        [Fact]
        public void StayInTheInitialPosition0And0()
        {
            Coordinates coordinates = new ("0,0");
            Rover rover = new Rover();
            
            Assert.Equal(coordinates, rover.Position());
        }
        
        
        [Fact]
        public void StayInTheInitialPPosition1And0()
        {
            Coordinates coordinates = new ("1,0");
            Rover rover = new Rover();
            
            Assert.Equal(coordinates, rover.Position());
        }
    }
}
