using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator.Classes;

namespace Exercises.Tests
{
    [TestClass]
    public class PostageTests
    {
        [TestMethod]
        public void PostalService1CTest()
        {
            PostalService1stClass myShipping = new PostalService1stClass();
            Assert.AreEqual(3.50, myShipping.CalculateRate(100, 2));
            Assert.AreEqual(4.70, myShipping.CalculateRate(100, 15));
            Assert.AreEqual(19.50, myShipping.CalculateRate(100, 18));
            Assert.AreEqual(50.00, myShipping.CalculateRate(100, 160));
        }

        [TestMethod]
        public void PostalService2CTest()
        {
           PostalService2ndClass myShipping = new PostalService2ndClass();
            Assert.AreEqual(0.35, myShipping.CalculateRate(100, 1));
            Assert.AreEqual(0.47, myShipping.CalculateRate(100, 10));
            Assert.AreEqual(1.95, myShipping.CalculateRate(100, 48));
            Assert.AreEqual(5.00, myShipping.CalculateRate(100, 176));
        }

        [TestMethod]
        public void PostalService3CTest()
        {
            PostalService3rdClass myShipping = new PostalService3rdClass();
            Assert.AreEqual(0.20, myShipping.CalculateRate(100, 0.32));
            Assert.AreEqual(0.24, myShipping.CalculateRate(100, 9));
            Assert.AreEqual(1.50, myShipping.CalculateRate(100, 32));
            Assert.AreEqual(1.70, myShipping.CalculateRate(100, 144));
        }

        [TestMethod]
        public void FexEdTest()
        {
            FexEd myShipping = new FexEd();
            Assert.AreEqual(20.00, myShipping.CalculateRate(1, 1));
            Assert.AreEqual(20.00, myShipping.CalculateRate(100, 47));
            Assert.AreEqual(23.00, myShipping.CalculateRate(499, 49));
            Assert.AreEqual(28.00, myShipping.CalculateRate(501, 64));
        }

        [TestMethod]
        public void SPU1DayTest()
        {
            SPUNextDay myShipping = new SPUNextDay();
            Assert.AreEqual(7.5, myShipping.CalculateRate(100, 16));
            Assert.AreEqual(7.5, myShipping.CalculateRate(10, 160));

        }

        [TestMethod]
        public void SPU2DayTest()
        {
            SPU2Day myShipping = new SPU2Day();
            Assert.AreEqual(5, myShipping.CalculateRate(100, 16));
            Assert.AreEqual(5, myShipping.CalculateRate(10, 160));

        }

        [TestMethod]
        public void SPU4DayTest()
        {
            SPU4Day myShipping = new SPU4Day();
            Assert.AreEqual(0.5, myShipping.CalculateRate(100, 16));
            Assert.AreEqual(0.5, myShipping.CalculateRate(10, 160));

        }
    }
}
