using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_1;
using System;

namespace FractionTests
{
    [TestClass]
    public class FractionTests
    {
        [TestMethod]
        public void ConstructorsTest()
        {
            Fraction a = new(1, 2);
            Fraction b = new(a);
            Assert.IsTrue(a.Equals(b));
        }
        [TestMethod]
        public void ToStringTest()
        {
            Fraction a = new(1, 2);
            a.ToString();
            string expected = "1 / 2";
            Assert.AreEqual(expected, a.ToString());
        }
        [TestMethod]
        public void OperatorsOverloadTest()
        {
            Fraction a = new(1, 2);
            Fraction b = new(1, 3);

            Fraction actualSum = a + b;
            Fraction expectedSum = new(5, 6);
            Assert.IsTrue(actualSum.Equals(expectedSum));

            Fraction actualProduct = a * b;
            Fraction expectedProduct = new(1, 6);
            Assert.IsTrue(actualProduct.Equals(expectedProduct));

            Fraction actualQuotient = a / b;
            Fraction expectedQuotient = new(3, 2);
            Assert.IsTrue(actualQuotient.Equals(expectedQuotient));
        }

        [TestMethod]
        public void InterfacesTest()
        { 
            Fraction a = new(6, 2);
            Fraction b = new(2, 3);
            Fraction c = new(4, 8);

            Fraction[] fractions = { a, b, c };

            Array.Sort(fractions);

            Assert.IsTrue(fractions[0].Equals(c));
            Assert.IsTrue(fractions[1].Equals(b));
            Assert.IsTrue(fractions[2].Equals(a));
        }
        
        [TestMethod]
        public void RoundTest()
        {
            Fraction a = new(1, 2);
            double actualUp = a.RoundUp();
            double actualDown = a.RoundDown();
            double expectedUp = 1;
            double expectedDown = 0;
            
            Assert.AreEqual(actualUp, expectedUp);
            Assert.AreEqual(actualDown, expectedDown);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "No zero-valued denominator")]
        public void ZeroDenominatorTest()
        {
            Fraction a = new(1, 0);
        }
    }
}
