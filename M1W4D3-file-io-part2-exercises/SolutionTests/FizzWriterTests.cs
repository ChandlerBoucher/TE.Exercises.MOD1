using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzWriter.Classes;

namespace SolutionTests
{
    [TestClass]
    public class FizzWriterTests
    {
        [TestMethod]
        public void TestForFizz()
        {
            Assert.AreEqual("Fizz", FizzBuzzer.Checker(9));
            Assert.AreEqual("Fizz", FizzBuzzer.Checker(13));
            Assert.AreEqual("Fizz", FizzBuzzer.Checker(11.3));
        }

        [TestMethod]
        public void TestForBuzz()
        {
            Assert.AreEqual("Buzz", FizzBuzzer.Checker(10));
            Assert.AreEqual("Buzz", FizzBuzzer.Checker(51));
            Assert.AreEqual("Buzz", FizzBuzzer.Checker(11.5));
        }

        [TestMethod]
        public void TestForFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz",FizzBuzzer.Checker(45));
            Assert.AreEqual("FizzBuzz",FizzBuzzer.Checker(30));
        }
    }
}
