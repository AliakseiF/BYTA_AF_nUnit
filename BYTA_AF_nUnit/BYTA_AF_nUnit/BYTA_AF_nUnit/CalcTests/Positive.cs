using System;
using CSharpCalculator;
using NUnit.Framework;

namespace BYTA_AF_nUnit
{
    class PositiveTest
    {
        Calculator mycalc = new Calculator();

        [SetUp]
        public void Init()
        {
            Console.WriteLine("Starting isPositive test...");
        }

        [TearDown]
        public void CleanUp()
        {
            Console.WriteLine("Finishing isPositive test...");
        }

        [TestCase("1", true)]
        [TestCase("-1", false)]
        [TestCase("0", false)]
        public void SpecificTest(string a, bool c)
        {
            bool d = mycalc.isPositive(a);
            Console.WriteLine("{0} isPositive ? - {1}", a, d);
            Assert.AreEqual(c, d);
        }

        [Test]
        public void CheckError()
        {
            try
            {
                mycalc.isPositive("a");
            }
            catch (NotFiniteNumberException ex)
            {
                Console.WriteLine(ex.Message);
                Assert.AreEqual("Wrong input",ex.Message);
            }

        }
    }
}
