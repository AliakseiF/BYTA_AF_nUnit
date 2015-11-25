using System;
using CSharpCalculator;
using NUnit.Framework;

namespace BYTA_AF_nUnit
{
    class NegativeTest
    {
        Calculator mycalc = new Calculator();

        [SetUp]
        public void Init()
        {
            Console.WriteLine("Starting isNegative test...");
        }

        [TearDown]
        public void CleanUp()
        {
            Console.WriteLine("Finishing isNegative test...");
        }

        [TestCase("1", false)]
        [TestCase("-1", true)]
        [TestCase("0", false)]
        public void SpecificTest(string a, bool c)
        {
            bool d = mycalc.isNegative(a);
            Console.WriteLine("{0} isNegative ? - {1}", a, d);
            Assert.AreEqual(c, d);
        }

        [Test]
        public void CheckError()
        {
            try
            {
                mycalc.isNegative("a");
            }
            catch (NotFiniteNumberException ex)
            {
                Console.WriteLine(ex.Message);
                Assert.AreEqual("Wrong input", ex.Message);
            }

        }
    }
}