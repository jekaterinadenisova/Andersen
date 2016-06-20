using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector
{
    class Vector
    {
        public Points beginPoint { get; set; } 
        public Points endPoint { get; set; } 
        public Vector(Points x1, Points x2)
         { 
             beginPoint = x1; 
             endPoint = x2; 
         }

        public double Length
        {
            get 
            {
                Points differenceOfVectors  = new Points(endPoint.X - beginPoint.X, endPoint.Y - beginPoint.Y, endPoint.Z - beginPoint.Z);
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
            return string.Format("({0},{1})", beginPoint, endPoint);
        }


        public void GetVector()
        {
            
        } 
    }

}

