using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    /// <summary>
    /// Summary description for WordCountTest
    /// </summary>
    [TestClass]
    public class WordCountTest
    {
                //This Compares Dictionaries Since It Does Not Exist
        private void AssertCollections(Dictionary<string, int> expected, Dictionary<string, int> actual)
        {
            foreach (KeyValuePair<string, int> kvp in expected)
            {
                if (!actual.ContainsKey(kvp.Key))
                {
                    Assert.Fail();
                }
                Assert.AreEqual(kvp.Value, actual[kvp.Key]);
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

        [TestMethod]
        public void WrdCountTest()
        {
            WordCount Counter = new WordCount();

            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"ba", 2 },
                {"black", 1 },
                {"sheep", 1 }
            };
            Dictionary<string, int> actual = Counter.GetCount(new string[] { "ba", "ba", "black", "sheep" });
            AssertCollections(expected, actual);

            Counter = new WordCount();

            expected = new Dictionary<string, int>
            {
                { "for", 3},
                { "nor", 2},
                { "xor", 1}
            };
            actual = Counter.GetCount(new string[] { "for", "nor", "for", "xor", "nor", "for" });
            AssertCollections(expected, actual);

            Counter = new WordCount();

            expected = new Dictionary<string, int> { };
            actual = Counter.GetCount(new string[] { });
            AssertCollections(expected, actual);
        }

    }
}

