using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polynoms;


namespace PolynomeUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EqualsPolynoms()
        {
            Polynome firstPolynom = new Polynome(1, 2, 3);
            Polynome secondPolynom = new Polynome(1, 2, 3);
            bool expected = true;
            Assert.AreEqual(expected, firstPolynom == secondPolynom, "Значения не равны!");

        }
            [TestMethod]
        public void SummaOfPolynoms()
        {
            Polynome firstPolynom = new Polynome(1, 2, 3);
            Polynome secondPolynom = new Polynome(1, 2, 3);

            Polynome expected = new Polynome(2, 4, 6);
            Assert.AreEqual(expected, firstPolynom + secondPolynom, "Значения не равны!");
        }


        [TestMethod]
        public void DefferenceOfPolynoms()
        {
            Polynome firstPolynom = new Polynome(1, 2, 3);
            Polynome secondPolynom = new Polynome(1, 2, 3);

            Polynome expected = new Polynome(0, 0, 0);
            Assert.AreEqual(expected, firstPolynom - secondPolynom, "Значения не равны!");

        }


        [TestMethod]
        public void MulticationOfPolynoms()
        {
            Polynome firstPolynom = new Polynome(1, 2, 3);
            Polynome secondPolynom = new Polynome(1, 2, 3);

            Polynome expected = new Polynome(1, 2, 3, 2, 4, 6, 3, 6, 9);

            Assert.AreEqual(expected, firstPolynom * secondPolynom, "Значения не совпадают!");
        }

    }
}

