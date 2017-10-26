using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    /// <summary>
    /// Summary description for NonStartTest
    /// </summary>
    [TestClass]
    public class NonStartTest
    {


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void NonStarter()
        {
            NonStart nonStarter = new NonStart();
            Assert.AreEqual("ellohere", nonStarter.GetPartialString("Hello", "There"));
            Assert.AreEqual("ickaxe", nonStarter.GetPartialString("", "Pickaxe"));
            Assert.AreEqual("lick", nonStarter.GetPartialString("flick", ""));
        }
    }
}
