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
            Assert.Equal("0,0", Rover.Position());
        }
    }
}
