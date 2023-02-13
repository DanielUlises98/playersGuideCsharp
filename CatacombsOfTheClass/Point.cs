using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatacombsOfTheClass
{
    public class Point
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }

        public Point()
        {
            CoordinateX = 0;
            CoordinateY = 0;
        }
        public Point(int coordinateX, int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
    }
}
