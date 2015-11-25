using System;
using NUnit.Framework;
using TaxiPark;

namespace BYTA_AF_nUnit.TaxiParkTests
{
    class FindCarByParametersTests
    {
        TaxiParkCars myPark = new TaxiParkCars();

        [SetUp]
        public void Init()
        {
            Console.WriteLine("Starting test...");
        }

        [TearDown]
        public void CleanUp()
        {
            Console.WriteLine("Finishing test...");
        }


        [TestCase("Black", 4)]
        [TestCase("UnrealColor", 0)]
        public void FindCarByColor(string a, int b)
        {
            int xcount = myPark.FindCarByParameters(a, "", 0, 0, 0, 0);
            Assert.AreEqual(b, xcount);
            Console.WriteLine("{0} = {1}", b, xcount);
        }
    }
}
