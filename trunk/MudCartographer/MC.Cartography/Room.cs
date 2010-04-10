using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MudCartographer
{
    public class Room
    {
        public Point3D Position;

        public Room(Point3D position)
        {
            this.Position = position;
        }
        public double X { get { return Position.X; } }
        public double Y { get { return Position.Y; } }
        public double Z { get { return Position.Z; } }

        public void changePosition(Point3D newPosition)
        {
            Position = newPosition;
        }
    }
}
