using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixProject;

namespace MatrixUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSumOfMatrix()
        {
            MatrixClass a = new MatrixClass(3);
                         MatrixClass b = new MatrixClass(3);
                       for (int i = 0; i < 3; i++)
                                 for (int j = 0; j < 3; j++)
                                 {
                                     a[i, j] = 1;
                                     b[i, j] = 2;
                                 }
            
             MatrixClass exp = new MatrixClass(3);
                         for (int i = 0; i < 3; i++)
                                 for (int j = 0; j < 3; j++)
                                     exp[i, j] = 3;
            


             Assert.AreEqual(exp, a + b, null, "Значения не равны");


        }

        [TestMethod]
        public void TestDefferenceOfMatrix()
        {
            MatrixClass firstTestMatrix = new MatrixClass(3);
            MatrixClass secondTestMatrix = new MatrixClass(3);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    firstTestMatrix[i, j] = 2;
                    secondTestMatrix[i, j] = 1;
                }


            MatrixClass exp = new MatrixClass(3);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    exp[i, j] = 1;


            Assert.AreEqual(exp, firstTestMatrix - secondTestMatrix, null, "Значения не равны");

        }

        [TestMethod]
        public void TestMultiplicationOfMatrix()
        {
            MatrixClass firstTestMatrix = new MatrixClass(3);
            MatrixClass secondTestMatrix = new MatrixClass(3);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    firstTestMatrix[i, j] = 1;
                    secondTestMatrix[i, j] = 2;
                }
            MatrixClass exp = new MatrixClass(3);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    exp[i, j] = 6;



            Assert.AreEqual(exp, firstTestMatrix * secondTestMatrix, null, "Значения не равны");


        }

    }
}
