using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TaxiPark;

namespace BYTA_AF_nUnit.TaxiParkTests
{
    class ParkTotalPriceTests
    {
        TaxiParkCars myPark = new TaxiParkCars();
        public List<Car> testCarList = new List<Car>();
        Car testCar = new Car();
        Randomizer rnd = new Randomizer();

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

        [Test]
        public void CheckTotalPrice()
        {
            int carcount = rnd.Next(10);
            int TotalPrice=0;
            for (int i = 1; i < carcount; i++)
            {
                //adding new cars to list
                int randomPrice = rnd.Next(100000);
                testCar = new Car(rnd.GetString(5), rnd.GetString(5), randomPrice, rnd.Next(100), rnd.Next(100), i);
                Console.WriteLine("new car has price: {0} $", testCar.carPrice);
                testCarList.Add(testCar);
                TotalPrice = TotalPrice + randomPrice;
            }
            int x = myPark.ParkTotalprice(testCarList);
            Assert.AreEqual(TotalPrice, x);
            Console.WriteLine("{0} = {1}", TotalPrice, x);
        }

        [TestCase(100, 200, 300)]
        [TestCase(100, -200, -100)]
        [TestCase(0, 100, 100)]
        public void SpecTest(int a, int b, int c)
        {
            List<Car> testCarList2 = new List<Car>();
            Car car1 = new Car(rnd.GetString(5), rnd.GetString(5), a, rnd.Next(100), rnd.Next(100), 1);
            Car car2 = new Car(rnd.GetString(5), rnd.GetString(5), b, rnd.Next(100), rnd.Next(100), 2);
            testCarList2.Add(car1);
            testCarList2.Add(car2);
            int x = myPark.ParkTotalprice(testCarList2);
            Assert.AreEqual(c, x);
            Console.WriteLine("{0} = {1}", c, x);
        }
    }
}
