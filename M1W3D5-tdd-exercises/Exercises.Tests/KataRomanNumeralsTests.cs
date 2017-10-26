using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataRomanNumeralsTests
    {
        [TestMethod]
        public void RomanNumeralConversionTest()
        {
            KataRomanNumerals converter = new KataRomanNumerals();
            Assert.AreEqual("I", converter.ConvertToRomanNumeral(1));
            Assert.AreEqual("III", converter.ConvertToRomanNumeral(3));
            Assert.AreEqual("X", converter.ConvertToRomanNumeral(10));
            Assert.AreEqual("MMCMXCIX", converter.ConvertToRomanNumeral(2999));

            Assert.AreEqual(1, converter.ConvertToArabic("I"));
            Assert.AreEqual(3, converter.ConvertToArabic("III"));
            Assert.AreEqual(10, converter.ConvertToArabic("X"));
            Assert.AreEqual(2999, converter.ConvertToArabic("MMCMXCIX"));
        }
    }
}
