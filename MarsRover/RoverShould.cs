using System;
using Xunit;

namespace MarsRover
{
    public class RoverShould
    {

        [Theory]
        [InlineData(1,1, Direction.South)]
        [InlineData(1,3, Direction.North)]
        [InlineData(1,4, Direction.East)]
        [InlineData(2,3, Direction.West)]
        public void getCurrentPointFromStartingPoint(int x, int y, Direction direction)
        {
            var rover = new Rover(new Point(x,y), direction);
            Assert.Equal(rover.Point, new Point(x,y));
            Assert.Equal(rover.Direction, direction);
        }
    }

    public enum Direction
    {
        North, South, East, West
    }

    public class Rover
    {
        public Point Point { get; }
        public Direction Direction { get; }

        public Rover(Point point, Direction direction)
        {
            Point = point;
            Direction = direction;
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