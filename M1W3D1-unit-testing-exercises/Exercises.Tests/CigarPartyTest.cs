using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        [TestMethod]
        public void PartySuccessTest()
        {
            CigarParty myParty = new CigarParty();
            Assert.AreEqual(false, myParty.HaveParty(30, false));
            Assert.AreEqual(true, myParty.HaveParty(50, false));
            Assert.AreEqual(true, myParty.HaveParty(70, true));
        }
    }
}
