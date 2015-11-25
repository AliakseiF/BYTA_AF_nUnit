using System;
using CSharpCalculator;
using NUnit.Framework;

namespace BYTA_AF_nUnit
{
    class MultiplyTest
    {
        Calculator mycalc = new Calculator();
        Random rnd = new Random();

        [SetUp]
        public void Init()
        {
            Console.WriteLine("Starting multiply test...");
        }

        [TearDown]
        public void CleanUp()
        {
            Console.WriteLine("Finishing multiply test...");
        }

        [Test]
        public void BaseTest()
        {
            double a = rnd.Next(100);
            Console.WriteLine(a);
            double b = rnd.Next(100);
            Console.WriteLine(b);
            var c = mycalc.Multiply(a, b);
            Console.WriteLine("{0} x {1} = {2}",a,b,c);
            Assert.AreEqual(c, a*b);
        }

        [TestCase(0, 2, 0)]
        [TestCase(-1, 2, -2)]
        [TestCase(-1, -2, 2)]
        public void SpecificTest( double a, double b, double c)
        {
            double d = mycalc.Multiply(a, b);
            Console.WriteLine("{0} x {1} = {2}", a, b, d);
            Assert.AreEqual(c, d);
        }
    }
}
