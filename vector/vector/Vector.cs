using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector
{
    public class Vector
    {
        public Points BeginPoint { get; set; } 
        public Points EndPoint { get; set; } 
        public Vector(Points x1, Points x2)
         { 
             BeginPoint = x1; 
             EndPoint = x2; 
         }

        public double Length
        {
            get 
            {
                Points differenceOfVectors  = new Points(EndPoint.X - BeginPoint.X, EndPoint.Y - BeginPoint.Y, EndPoint.Z - BeginPoint.Z);
                return Math.Sqrt(Math.Pow(differenceOfVectors.X, 2) + Math.Pow(differenceOfVectors.Y, 2) + Math.Pow(differenceOfVectors.Z, 2));
            }
        }
        public static double operator +(Vector x1, Vector x2)
         { 
             return x1.Length + x2.Length; 
         } 
         public static double operator -(Vector x1, Vector x2)
         { 
             return x1.Length-x2.Length; 
         } 
         public static double operator *(Vector x1, Vector x2)
         { 
             return x1.Length* x2.Length; 
         }

        public override string ToString()
        {
            return string.Format("({0},{1})", BeginPoint, EndPoint);
        }


        public void GetVector()
        {
            
        } 
    }

}

