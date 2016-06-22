using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynoms
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первый полином: ");
                    string [] firstPolynom = Console.ReadLine().Split(',');
                    Console.WriteLine("Введите второй полином: ");
                    string [] secondPolynom = Console.ReadLine().Split(',');
                    double[] inputFirstPolynom = new double[firstPolynom.Length];
                    double [] inputSecondPolynom = new double[secondPolynom.Length];
                    
                    
                    for (int i = 0; i < firstPolynom.Length; i++)
                       {
                          inputFirstPolynom[i] = double.Parse(firstPolynom[i]);
                        }
                  
                    for (int i = 0; i < secondPolynom.Length; i++)
                       {
                          inputSecondPolynom[i] = double.Parse(secondPolynom[i]);
                       }

                    Polynome p1 = new Polynome(inputFirstPolynom);
                    Polynome p2 = new Polynome(inputSecondPolynom);

                    Console.WriteLine("Сумма полиномов:{0} ", p1 + p2);
                    Console.WriteLine("Разность полиномов:{0} ", p1 - p2);
                    Console.WriteLine("Произведение полиномов:{0} ", p1 * p2);
                    Console.WriteLine("Равенство полиномов:{0} ", p1 == p2);
                    Console.ReadKey();

                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не числа, введите числа!");
                }
            }
        }
    }
}
