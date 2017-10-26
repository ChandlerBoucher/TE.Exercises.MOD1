using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    /// <summary>
    /// Summary description for SameFirstLastTest
    /// </summary>
    [TestClass]
    public class SameFirstLastTest
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
        public void firstLastTest()
        {
            SameFirstLast firstLastTest = new SameFirstLast();
            Assert.AreEqual(true, firstLastTest.IsItTheSame(new int[] { 4, 8, 4 }));
            Assert.AreEqual(true, firstLastTest.IsItTheSame(new int[] { 1, 2, 3, 4, 1 }));
            Assert.AreEqual(false, firstLastTest.IsItTheSame(new int[] { 1, 2, 3, 4 }));

        }
    }
}
