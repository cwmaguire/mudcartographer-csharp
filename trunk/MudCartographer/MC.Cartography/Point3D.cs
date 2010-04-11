using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MC.Cartography;
// Class Point3D
// Copyright 2003 Eric Marchesin - <eric.marchesin@laposte.net>

namespace MudCartographer
{
    public class Point3D
    {
        double[] coordinates = new double[3];

        public double X { set { coordinates[0] = value; } get { return coordinates[0]; } }
        public double Y { set { coordinates[1] = value; } get { return coordinates[1]; } }
        public double Z { set { coordinates[2] = value; } get { return coordinates[2]; } }

        public Point3D(double CoordinateX, double CoordinateY, double CoordinateZ)
        {
            X = CoordinateX; Y = CoordinateY; Z = CoordinateZ;
        }

        public double this[int CoordinateIndex]
        {
            get { return coordinates[CoordinateIndex]; }
            set { coordinates[CoordinateIndex] = value; }
        }

        public static double DistanceBetween(Point3D P1, Point3D P2)
        {
            return Math.Sqrt(Math.Pow(P1.X - P2.X, 2) + Math.Pow(P1.Y - P2.Y,2) + Math.Pow(P1.Z - P2.Z, 2));
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Point3D pointOfComparison = (Point3D) obj;
            return coordinates[0] == pointOfComparison.X && coordinates[1] == pointOfComparison[1] && coordinates[2] == pointOfComparison[2];
        }

        public override int GetHashCode()
        {
            double HashCode = 0;
            for (int i = 0; i < 3; i++) HashCode += this[i];
            return (int)HashCode;
        }
    }
}
