using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynoms
{
    public class Polynome
    {
        private double[] coefficient; 
 
 
         public Polynome(params double[] coefficients)
         { 
             coefficient = coefficients; 
         } 
 
 
         public double this[int n]
         {
             get { return coefficient[n]; }
             set { coefficient[n] = value; }
         } 
 

         public int Order
         { 
             get { return coefficient.Length; } 
         } 
 
 
         public override string ToString()
         { 
             return string.Format("коэффициенты полиномов " + string.Join(";*", coefficient)); 
         } 
 

 
 
         public static Polynome operator +(Polynome firstPolynom, Polynome secondPolynom)
         { 
             int itemsCount = Math.Max(firstPolynom.coefficient.Length, secondPolynom.coefficient.Length); 
             var result = new double[itemsCount]; 
             for (int i = 0; i<itemsCount; i++) 
             { 
                 double a = 0; 
                 double b = 0; 
                 if (i< firstPolynom.coefficient.Length) 
                 { 
                     a = firstPolynom[i]; 
                 } 
                 if (i< secondPolynom.coefficient.Length) 
                 { 
                     b = secondPolynom[i]; 
                 } 
                 result[i] = a + b; 
             } 
             return new Polynome(result); 
         } 
 
         public static Polynome operator -(Polynome firstPolynom, Polynome secondPolynom)
         { 
             int itemsCount = Math.Max(firstPolynom.coefficient.Length, secondPolynom.coefficient.Length); 
             var result = new double[itemsCount]; 
             for (int i = 0; i<itemsCount; i++) 
             { 
                 double a = 0; 
                 double b = 0; 
                 if (i< firstPolynom.coefficient.Length) 
                 { 
                     a = firstPolynom[i]; 
                 } 
                 if (i< secondPolynom.coefficient.Length) 
                 { 
                     b = secondPolynom[i]; 
                 } 
                 result[i] = a - b; 
             } 
             return new Polynome(result); 
         } 
 
 
         public static Polynome operator *(Polynome firstPolynom, Polynome secondPolynom)
         { 
             int itemsCount = firstPolynom.coefficient.Length * secondPolynom.coefficient.Length; 
             var result = new double[itemsCount]; 
             int k = 0; 
             for (int i = 0; i< firstPolynom.coefficient.Length; i++) 
             { 
                 for (int j = 0; j< secondPolynom.coefficient.Length; j++) 
                 { 
                     result[k] += firstPolynom[i] * secondPolynom[j]; 
                     k++; 
                 } 
             } 
 
 
             return new Polynome(result); 
         } 
 
 
 
 
         public override bool Equals(object obj)
         { 
             return obj.ToString()== ToString(); 
         } 
         public override int GetHashCode()
         { 
            return ToString().GetHashCode(); 
         } 
 
 
         public static bool operator ==(Polynome firstPolynom, Polynome secondPolynom)
         { 
             if (firstPolynom.coefficient.Length != secondPolynom.coefficient.Length) 
             { 
                 return false; 
             } 
             for (int i = 0; i< firstPolynom.coefficient.Length; i++) 
             { 
                 if (firstPolynom[i] != secondPolynom[i]) 
                 { 
                     return false; 
                 } 
             } 
             return true; 
         } 
 

         public static bool operator !=(Polynome firstPolynom, Polynome secondPolynom)
         { 
             return !(firstPolynom == secondPolynom); 
         } 

        
    }
}
