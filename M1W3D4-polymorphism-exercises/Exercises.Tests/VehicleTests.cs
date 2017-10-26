using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TollBoothCalculator.Classes;

namespace Exercises.Tests
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void CarTest()
        { 
            Car tstCar = new Car(true);
            Car tstCar2 = new Car(false);

            Assert.AreEqual("Car", tstCar.VehicleType);
            Assert.AreEqual(3, tstCar.CalculateToll(100));//Testing for Toll w/ Trailer

            Assert.AreEqual(2, tstCar2.CalculateToll(100));//Testing For Toll w/o Trailer
        }

        [TestMethod]
        public void TruckTest()
        {
            Truck testTruck = new Truck(3);
            Assert.AreEqual(4.00, testTruck.CalculateToll(100));

            testTruck = new Truck(4);
            Assert.AreEqual(4.00, testTruck.CalculateToll(100));

            testTruck = new Truck(6);
            Assert.AreEqual(4.50, testTruck.CalculateToll(100));

            testTruck = new Truck(8);
            Assert.AreEqual(4.80, testTruck.CalculateToll(100));

            testTruck = new Truck(9);
            Assert.AreEqual(4.80, testTruck.CalculateToll(100));
        }

        [TestMethod]
        public void TankTest()
        {
            Tank testTank = new Tank();
            Assert.AreEqual(0, testTank.CalculateToll(200));
        }
    }
}
