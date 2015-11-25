using System;

namespace TaxiPark
{
    public class TaxiPark
    {
        static void Main(string[] args)
        {
            TaxiParkCars taxiPark = new TaxiParkCars();
            //XML implemented only for Car:Business:BMW
            taxiPark.SerializeToXML();
            taxiPark.DeserializeFromXML();

            //json
            taxiPark.SerializeToJson();
            taxiPark.DeserializeFromJson();

            taxiPark.ParkTotalprice(taxiPark.CarList);
            taxiPark.OrderCarsByfuelConsumption();

            Console.WriteLine("\nPlease enter car color or press [Enter] to skip this step");
            string a = Console.ReadLine();
            Console.WriteLine("Please enter car type or press [Enter] to skip this step");
            string b = Console.ReadLine();
            Console.WriteLine("Please enter car price or press [Enter] to skip this step");
            int cc;
            Int32.TryParse(Console.ReadLine(), out cc);
            Console.WriteLine("Please enter car fuel consumption or press [Enter] to skip this step");
            int d;
            Int32.TryParse(Console.ReadLine(), out d); ;
            Console.WriteLine("Please enter car rate or press [Enter] to skip this step");
            int e;
            Int32.TryParse(Console.ReadLine(), out e);
            Console.WriteLine("Please enter car number or press [Enter] to skip this step");
            int f;
            Int32.TryParse(Console.ReadLine(), out f);
            taxiPark.FindCarByParameters(a,b,cc,d,e,f);
            Console.ReadKey();
        }
    }
}
