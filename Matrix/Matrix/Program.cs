using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите размерность матрицы: ");
                int matrixRank = int.Parse(Console.ReadLine());



                Random rand = new Random();
                MatrixClass firstMatrix = new MatrixClass(matrixRank);
                MatrixClass secondMatrix = new MatrixClass(matrixRank);

                for (int i = 0; i < matrixRank; i++)
                    for (int j = 0; j < matrixRank; j++)
                    {
                        firstMatrix[i, j] = rand.Next(1, 4);
                        secondMatrix[i, j] = rand.Next(1, 4);
                    }


                Console.WriteLine("Первая матрица:\n");
                firstMatrix.PrintMatrix();
                Console.WriteLine("\nВторая матрица:\n");
                secondMatrix.PrintMatrix();
                Console.WriteLine("\nСумма матриц:\n");
                (firstMatrix + secondMatrix).PrintMatrix();
                Console.WriteLine("\nРазность матриц:\n");
                (firstMatrix - secondMatrix).PrintMatrix();
                Console.WriteLine("\nПроизведение матриц\n");
                (firstMatrix * secondMatrix).PrintMatrix();
                Console.ReadKey();
            }

            catch (OverflowException)
            {
                Console.WriteLine("Вы ввели недопустимый размер!");
                Console.ReadKey();
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Вы ввели недопустимый размер!");
                Console.ReadKey();
            }
        }
    }
}
