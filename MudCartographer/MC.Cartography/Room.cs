using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MudCartographer
{
    public class Room
    {
        public Point3D Position;

        public Room(double X, double Y, double Z)
        {
            this.Position = new Point3D(X, Y, Z);
        }

        public Room(Point3D position)
        {
            this.Position = position;
        }
        public double X { get { return Position.X; } }
        public double Y { get { return Position.Y; } }
        public double Z { get { return Position.Z; } }

        public void ChangePosition(Point3D newPosition)
        {
            Position = newPosition;
        }

        public void ChangePosition(double X, double Y, double Z)
        {
            Position.X = X;
            Position.Y = Y;
            Position.Z = Z;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Room roomOfComparison = (Room)obj;
            return roomOfComparison.Position.Equals(this.Position);
        }
    }
}
