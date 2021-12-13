using System;
using MarsRoverGuided.Tests;
using Xunit;

namespace MarsRoverGuided
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
