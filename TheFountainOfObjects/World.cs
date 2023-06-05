using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFountainOfObjects
{
    internal class World
    {
        private RoomType[,] GridWorld { get; init; }
        private PointInTheWorld fountainCoordinates { get; init; }
        private PointInTheWorld exitCoordinates { get; init; }
        public World(SizeOfWorld sizeOfWorld, PointInTheWorld fountainCoordinates, PointInTheWorld exitCoordinates)
        {
            GridWorld = new RoomType[sizeOfWorld.GetX, sizeOfWorld.GetY];
            this.fountainCoordinates = fountainCoordinates;
            this.exitCoordinates = exitCoordinates;
        }

        public void CreateWorld()
        {
            GridWorld[fountainCoordinates.GetX, fountainCoordinates.GetY] = RoomType.FountainRoom;
            GridWorld[exitCoordinates.GetX, exitCoordinates.GetY] = RoomType.ExitRoom;
        }
        enum RoomType
        {
            EmptyRoom,
            FountainRoom,
            ExitRoom
        }
    }
    internal class SizeOfWorld
    {
        public int GetX { get; init; }

        public int GetY { get; init; }
        public SizeOfWorld(int x, int y)
        {
            GetX = x;
            GetY = y;
        }

    }
    internal class PointInTheWorld : SizeOfWorld
    {
        public PointInTheWorld(int x, int y) : base(x, y)
        {
            GetX = x;
            GetY= y;
        }
    }
}
