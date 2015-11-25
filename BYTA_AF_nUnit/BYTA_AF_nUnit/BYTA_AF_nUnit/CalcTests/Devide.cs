using System;
using CSharpCalculator;
using NUnit.Framework;

namespace BYTA_AF_nUnit
{
    class DevideTest
    {
        Calculator mycalc = new Calculator();
        Random rnd = new Random();

        [SetUp]
        public void Init()
        {
            Console.WriteLine("Starting devide test...");
        }

        [TearDown]
        public void CleanUp()
        {
            Console.WriteLine("Finishing devide test...");
        }

        [Test]
        public void BaseTest()
        {
            double a = rnd.Next(100);
            Console.WriteLine(a);
            double b = rnd.Next(100);
            Console.WriteLine(b);
            var c = mycalc.Divide(a, b);
            Console.WriteLine("{0} / {1} = {2}",a,b,c);
            Assert.AreEqual(c, a/b);
        }

        [TestCase(0, 2, 0)]
        [TestCase(-2, 2, -1)]
        [TestCase(-1, -2, 0.5)]
        [TestCase(1, 0, Double.PositiveInfinity)]
        public void SpecificTest(double a, double b, double c)
        {
            double d = mycalc.Divide(a, b);
            Console.WriteLine("{0} / {1} = {2}", a, b, d);
            Assert.AreEqual(c, d);
        }
    }
}
