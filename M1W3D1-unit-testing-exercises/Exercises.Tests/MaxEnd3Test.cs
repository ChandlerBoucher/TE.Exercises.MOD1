using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    /// <summary>
    /// Summary description for MaxEnd3Test
    /// </summary>
    [TestClass]
    public class MaxEnd3Test
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
        public void MaxEndTest()
        {
            MaxEnd3 myMax = new MaxEnd3();
            CollectionAssert.AreEquivalent (new int[] { 3, 3, 3 }, myMax.MakeArray(new int[] { 1, 2, 3 }));
            CollectionAssert.AreEquivalent (new int[] { 21, 21, 21 }, myMax.MakeArray(new int[] { 21, 4, 6 }));
            CollectionAssert.AreEquivalent (new int[] { 6, 6, 6 }, myMax.MakeArray(new int[] { 6, 4, 2 }));
        }
    }
}
