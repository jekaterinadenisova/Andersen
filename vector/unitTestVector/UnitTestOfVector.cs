using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using vector;



namespace unitTestVector
{
    [TestClass]
    public class UnitTestOfVector
    {
        [TestMethod]
        public void SummaOfVectorsTest()
        {
            Vector firstVector = new Vector(new Points(2, 0, 2), new Points(0, 1, 0));
            Vector secondVector = new Vector(new Points(0, 1, 0), new Points(2, 0, 2));
            double expected = 6;
            double summa = firstVector + secondVector;
            Assert.AreEqual(expected, summa, null, "Значения не равны!");

        }


        [TestMethod]
        public void DifferenceOfVectors()
        {
            Vector firstVector = new Vector(new Points(2, 0, 2), new Points(0, 1, 0));
            Vector secondVector = new Vector(new Points(0, 1, 0), new Points(2, 0, 2));
            double expected = 0;
            double difference = firstVector - secondVector;
            Assert.AreEqual(expected, difference, null, "Значения не равны!");
        }

        [TestMethod]
        public void MultiplicationOfVectorTest()
        {
            Vector firstVector = new Vector(new Points(2, 0, 2), new Points(0, 1, 0));
            Vector secondVector = new Vector(new Points(0, 1, 0), new Points(2, 0, 2));
            double expected = 9;
            double multiplication = firstVector * secondVector;
            Assert.AreEqual(expected, multiplication, null, "Значения не равны!");
        }

       
    }
}
