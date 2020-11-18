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
        public void GetCurrentPointFromStartingPoint(int x, int y, Direction direction)
        {
            var rover = new Rover(new Point(x,y), direction);
            Assert.Equal(new Point(x,y), rover.Point);
            Assert.Equal(direction, rover.Direction);
        }

        [Fact]
        public void GetForwardFromInitialPositionAndDirection()
        {
            var rover = new Rover(new Point(0,0), Direction.North);

            rover.Move(Move.Forward);
            
            Assert.Equal(new Point(0, 1), rover.Point);   
            Assert.Equal(Direction.North, rover.Direction);
        }
        
        [Fact]
        public void GetForwardFromInitialPositionAndDirectionv2()
        {
            var rover = new Rover(new Point(1,0), Direction.North);

            rover.Move(Move.Forward);
            
            Assert.Equal(new Point(1, 1), rover.Point);   
            Assert.Equal(Direction.North, rover.Direction);
        }
        
    }

    public enum Move
    {
        Forward
    }

    public enum Direction
    {
        North, South, East, West
    }

    public class Rover
    {
        public Point Point { get; private set; }
        public Direction Direction { get; }

        public Rover(Point point, Direction direction)
        {
            Point = point;
            Direction = direction;
        }

        public void Move(Move move)
        {
            Point = new Point(Point.X,Point.Y + 1);
        }
    }

    public struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"x:{X} y:{Y}";
    }
}