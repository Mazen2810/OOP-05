using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.First_Project
{
    class Point3D : IComparable<Point3D> , ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D()
        {

        }
        public Point3D(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }


        #region Overloading Methods [Relational Operator]
        public static bool operator ==(Point3D left, Point3D right)
        {
            if (left.X == right.X && left.Y == right.Y && left.Z == right.Z)
                return true;
            else
                return false;
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            if (left.X == right.X && left.Y == right.Y && left.Z == right.Z)
                return false;
            else
                return true;
        } 
        #endregion

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

       

        public int CompareTo(Point3D? other)
        {
     

            int CompareX = this.X.CompareTo(other?.X);
            if(CompareX !=0) 
                return CompareX;

            return this.Y.CompareTo(other?.Y);
        }

        public object Clone()
        {
            return new Point3D(X,Y,Z)
            {
                X = this.X,
                Y = this.Y,
                Z = this.Z
            };
        }
    }
}
