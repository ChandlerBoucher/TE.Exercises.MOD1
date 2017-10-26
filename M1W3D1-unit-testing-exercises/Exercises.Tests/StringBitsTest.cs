using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{

    [TestClass]
    public class StringBitsTest
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
        public void StrBitsTest()
        { 
            StringBits stringBits = new StringBits();
            Assert.AreEqual("Hlo", stringBits.GetBits("Hello"));
            Assert.AreEqual("H", stringBits.GetBits("Hi"));
            Assert.AreEqual("Hello", stringBits.GetBits("Heeololeo"));

        }
    }
}
