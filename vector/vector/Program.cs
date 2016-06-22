using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите координаты первого вектора через пробел: ");
                    string[] firstVectorCoordintes = Console.ReadLine().Split(' ');

                    Console.WriteLine("Введите координаты второго вектора через пробел: ");
                    string[] secondVectorCoordinates = Console.ReadLine().Split(' ');


                    if (firstVectorCoordintes.Length != 6 || secondVectorCoordinates.Length != 6)
                    {
                        Console.WriteLine("Ошибка ввода! Не верно введены координаты.");
                    }
                    else
                    {
                        Points beginOfPoint = new Points(int.Parse(firstVectorCoordintes[0]), int.Parse(firstVectorCoordintes[1]), int.Parse(firstVectorCoordintes[2]));
                        Points endOfPoint = new Points(int.Parse(firstVectorCoordintes[3]), int.Parse(firstVectorCoordintes[4]), int.Parse(firstVectorCoordintes[5]));

                        Points beginOfPoint2 = new Points(int.Parse(secondVectorCoordinates[0]), int.Parse(secondVectorCoordinates[1]), int.Parse(secondVectorCoordinates[2]));
                        Points endOfPoint2 = new Points(int.Parse(secondVectorCoordinates[3]), int.Parse(secondVectorCoordinates[4]), int.Parse(secondVectorCoordinates[5]));

                        Vector firstVector = new Vector(beginOfPoint, endOfPoint);
                        Vector secondVector = new Vector(beginOfPoint2, endOfPoint2);
                        double summaOfVectors = firstVector + secondVector;
                        double differenceOfVectors = firstVector - secondVector;
                        double multiplicationOfVectors = firstVector * secondVector;


                        Console.WriteLine("Координаты первого вектора: " +firstVector);
                        Console.WriteLine("Координаты второго вектора: "+secondVector);
                        Console.WriteLine("Сумма векторов: "+summaOfVectors);
                        Console.WriteLine("Разность векторов: "+differenceOfVectors);
                        Console.WriteLine("Скалярное произведение векторов: "+multiplicationOfVectors);
                        Console.ReadKey();
                    }
                }catch(FormatException)
                {
                    Console.WriteLine("Вы ввели не число!");
                }
           }
        }
    }
}

