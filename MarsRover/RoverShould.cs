using System;
using Xunit;

namespace MarsRover
{
    public class RoverShould
    {

        [Theory]
        [InlineData(1,1)]
        [InlineData(1,3)]
        public void getCurrentPointFromStartingPoint(int x, int y)
        {
            var rover = new Rover(new Point(x,y));
            Assert.Equal(rover.getCurrentPoint(), new Point(x,y));
        }
    }

    public class Rover
    {
        private readonly Point _point;

        public Rover(Point point)
        {
            _point = point;
        }

        public Point getCurrentPoint()
        {
            return _point;
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