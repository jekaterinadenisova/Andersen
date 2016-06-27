using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProject
{
    public class MatrixClass
    {
        double[,] matrix;
        int rowOfMatrix = 0, column = 0;

        public MatrixClass(int row, int col)
        {
            matrix = new double[row, col];
            rowOfMatrix = row; column = col;
        }

        public MatrixClass(int matrixRank )
        {
            matrix = new double[matrixRank, matrixRank];
            rowOfMatrix = column = matrixRank;
        }

        public double this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }
        public static MatrixClass operator +(MatrixClass first, MatrixClass second)
        {


            MatrixClass matrix = new MatrixClass(first.rowOfMatrix, first.column);
            try
            {
                if (first.rowOfMatrix != second.rowOfMatrix && first.column != second.column)
                {
                    throw new Exception("Сложение невозможно! Размеры матриц не совпадают!");
                }
                for (int i = 0; i < first.rowOfMatrix; i++)
                    for (int j = 0; j < first.column; j++)
                        matrix[i, j] = first[i, j] + second[i, j];
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return matrix;
        }

        public static MatrixClass operator -(MatrixClass first, MatrixClass second)
        {

            MatrixClass matrix = new MatrixClass(first.rowOfMatrix, first.column);
            try
            {
                if (first.rowOfMatrix != second.rowOfMatrix && first.column != second.column)
                {
                    throw new Exception("Вычитание невозможно! Размеры матриц не совпадают!");
                }
                for (int i = 0; i < first.rowOfMatrix; i++)
                    for (int j = 0; j < first.column; j++)
                        matrix[i, j] = first[i, j] - second[i, j];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return matrix;

        }


        public static MatrixClass operator *(MatrixClass first, MatrixClass second)
        {
            MatrixClass matrix = new MatrixClass(first.rowOfMatrix, first.column);
            try
            {
                if (first.rowOfMatrix != second.column && first.column != second.rowOfMatrix)
                {
                    throw new Exception("Умножение невозможно! Размеры матриц не совпадают!");
                }
                    for (int i = 0; i < first.rowOfMatrix; i++)
                    {
                        for (int j = 0; j < second.column; j++)
                        {
                            double sum = 0;
                            for (int r = 0; r < first.column; r++)
                                sum += first[i, r] * second[r, j];
                            matrix[i, j] = sum;
                        }
                    }
            }
            catch( Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return matrix;
        }



        public void PrintMatrix()
        {
            for (int i = 0; i < this.rowOfMatrix; i++)
            {
                for (int j = 0; j < this.column; j++)
                    Console.Write("{0}  ", this[i, j]);
                Console.Write("\n");
            }
        }
            public override bool Equals(object obj)
        {
            return obj.ToString() == ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
    }

