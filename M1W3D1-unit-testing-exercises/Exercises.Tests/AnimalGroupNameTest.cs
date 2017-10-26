using System;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
using System.Text;
using System.Collections.Generic;
>>>>>>> 12ba301e9cf864eea56c5f4fd8340cc62d184845
=======
using System.Text;
using System.Collections.Generic;
>>>>>>> 1200a8d96d1af397da75e9c3765c40dccec0a459
=======
using System.Text;
using System.Collections.Generic;
>>>>>>> 25f92f1c68457a8fe0611d0621132acd4944bed2
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    [TestClass]
    public class AnimalGroupNameTest
    {
=======
=======
>>>>>>> 1200a8d96d1af397da75e9c3765c40dccec0a459
=======
>>>>>>> 25f92f1c68457a8fe0611d0621132acd4944bed2
    /// <summary>
    /// Summary description for AnimalGroupNameTest
    /// </summary>
    [TestClass]
    public class AnimalGroupNameTest
    {
        public AnimalGroupNameTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

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

<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 12ba301e9cf864eea56c5f4fd8340cc62d184845
=======
>>>>>>> 1200a8d96d1af397da75e9c3765c40dccec0a459
=======
>>>>>>> 25f92f1c68457a8fe0611d0621132acd4944bed2
        [TestMethod]
        public void GetHerdTest()
        {
            // * Rhino -> Crash
            AnimalGroupName myGroup = new AnimalGroupName();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            Assert.AreEqual("Crash", myGroup.GetHerd("Rhino"), "Item in dictionary was not retrieved");
            Assert.AreEqual("unknown", myGroup.GetHerd("Cat"), "Unkown animal not properly referenced");
            
=======
            Assert.AreEqual("Crash", myGroup.GetHerd("Rhino"));
            Assert.AreEqual("unknown", myGroup.GetHerd("Cat"));
            Assert.AreEqual("unknown", myGroup.GetHerd(null));
>>>>>>> 12ba301e9cf864eea56c5f4fd8340cc62d184845
=======
            Assert.AreEqual("Crash", myGroup.GetHerd("Rhino"));
            Assert.AreEqual("unknown", myGroup.GetHerd("Cat"));
            Assert.AreEqual("unknown", myGroup.GetHerd(null));
>>>>>>> 1200a8d96d1af397da75e9c3765c40dccec0a459
=======
            Assert.AreEqual("Crash", myGroup.GetHerd("Rhino"));
            Assert.AreEqual("unknown", myGroup.GetHerd("Cat"));
            Assert.AreEqual("unknown", myGroup.GetHerd(null));
>>>>>>> 25f92f1c68457a8fe0611d0621132acd4944bed2
        }
    }
}
