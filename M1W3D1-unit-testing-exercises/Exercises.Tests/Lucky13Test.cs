using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    /// <summary>
    /// Summary description for Lucky13Test
    /// </summary>
    [TestClass]
    public class Lucky13Test
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
        public void GetLuckyTest()
        {
            Lucky13 LuckyLuck = new Lucky13();
            Assert.AreEqual(true, LuckyLuck.GetLucky(new int[] { 4, 8, 9 }), "Input was [4, 8, 9]");
            Assert.AreEqual(false, LuckyLuck.GetLucky(new int[] { 1, 7, 6 }), "Input was [1, 7, 6]");
            Assert.AreEqual(false, LuckyLuck.GetLucky(new int[] { 2, 2, 3 }), "Input was [2, 2, 3]");
            
        }
    }
    
}
