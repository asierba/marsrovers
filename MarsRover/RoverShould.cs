using System;
using Xunit;

namespace MarsRover
{
    public class RoverShould
    {
        [Fact]
        public void getCurrentPointFromInitialPoint()
        {
            var rover = new Rover(new Point(1,1));
            Assert.Equal(rover.getCurrentPoint(), new Point(1,1));
        }
    }

    public class Rover
    {
        public Rover(Point point)
        {
        }

        public Point getCurrentPoint()
        {
            return new Point(1,1);
        }
    }

    public struct Point
    {
        private readonly int _x;
        private readonly int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}