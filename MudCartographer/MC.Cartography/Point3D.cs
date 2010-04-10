using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Class Point3D
// Copyright 2003 Eric Marchesin - <eric.marchesin@laposte.net>

namespace MudCartographer
{
    public class Point3D
    {
        double[] coordinates = new double[3];

        /// <summary>
        /// Point3D constructor.
        /// </summary>
        /// <exception cref="ArgumentNullException">Argument array must not be null.</exception>
        /// <exception cref="ArgumentException">The Coordinates' array must contain exactly 3 elements.</exception>
        /// <param name="Coordinates">An array containing the three coordinates' values.</param>
        public Point3D(double[] Coordinates)
        {
            if (Coordinates == null) throw new ArgumentNullException();
            if (Coordinates.Length != 3) throw new ArgumentException("The Coordinates' array must contain exactly 3 elements.");
            X = Coordinates[0]; Y = Coordinates[1]; Z = Coordinates[2];
        }

        /// <summary>
        /// Point3D constructor.
        /// </summary>
        /// <param name="CoordinateX">X coordinate.</param>
        /// <param name="CoordinateY">Y coordinate.</param>
        /// <param name="CoordinateZ">Z coordinate.</param>
        public Point3D(double CoordinateX, double CoordinateY, double CoordinateZ)
        {
            X = CoordinateX; Y = CoordinateY; Z = CoordinateZ;
        }

        /// <summary>
        /// Accede to coordinates by indexes.
        /// </summary>
        /// <exception cref="IndexOutOfRangeException">Index must belong to [0;2].</exception>
        public double this[int CoordinateIndex]
        {
            get { return coordinates[CoordinateIndex]; }
            set { coordinates[CoordinateIndex] = value; }
        }

        /// <summary>
        /// Gets/Set X coordinate.
        /// </summary>
        public double X { set { coordinates[0] = value; } get { return coordinates[0]; } }

        /// <summary>
        /// Gets/Set Y coordinate.
        /// </summary>
        public double Y { set { coordinates[1] = value; } get { return coordinates[1]; } }

        /// <summary>
        /// Gets/Set Z coordinate.
        /// </summary>
        public double Z { set { coordinates[2] = value; } get { return coordinates[2]; } }

        /// <summary>
        /// Returns the distance between two points.
        /// </summary>
        /// <param name="P1">First point.</param>
        /// <param name="P2">Second point.</param>
        /// <returns>Distance value.</returns>
        public static double DistanceBetween(Point3D P1, Point3D P2)
        {
            return Math.Sqrt((P1.X - P2.X) * (P1.X - P2.X) + (P1.Y - P2.Y) * (P1.Y - P2.Y));
        }

        /// <summary>
        /// Object.Equals override.
        /// Tells if two points are equal by comparing coordinates.
        /// </summary>
        /// <exception cref="ArgumentException">Cannot compare Point3D with another type.</exception>
        /// <param name="Point">The other 3DPoint to compare with.</param>
        /// <returns>'true' if points are equal.</returns>
        public override bool Equals(object Point)
        {
            Point3D P = (Point3D)Point;
            if (P == null) throw new ArgumentException("Object must be of type " + GetType());
            bool Resultat = true;
            for (int i = 0; i < 3; i++) Resultat &= P[i].Equals(this[i]);
            return Resultat;
        }

        /// <summary>
        /// Object.GetHashCode override.
        /// </summary>
        /// <returns>HashCode value.</returns>
        public override int GetHashCode()
        {
            double HashCode = 0;
            for (int i = 0; i < 3; i++) HashCode += this[i];
            return (int)HashCode;
        }

        /// <summary>
        /// Object.GetHashCode override.
        /// Returns a textual description of the point.
        /// </summary>
        /// <returns>String describing this point.</returns>
        public override string ToString()
        {
            string Deb = "{";
            string Sep = ";";
            string Fin = "}";
            string Resultat = Deb;
            int Dimension = 3;
            for (int i = 0; i < Dimension; i++)
                Resultat += coordinates[i].ToString() + (i != Dimension - 1 ? Sep : Fin);
            return Resultat;
        }
    }
}
