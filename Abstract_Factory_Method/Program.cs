using Abstract_Factory_Method.AbstractFactory;
using Abstract_Factory_Method.Client;
using Abstract_Factory_Method.ConcreteFactory;
using System;

namespace Abstract_Factory_Method
{
    /// <summary>
    /// Abstract Factory Method Demo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ITwoWheelerFactory honda = new HondaFactory();
            VehicleClient hondaclient = new VehicleClient(honda, "Regular");

            Console.WriteLine("******* Honda **********");
            Console.WriteLine(hondaclient.GetMotorcycleName());
            Console.WriteLine(hondaclient.GetScooterName());

            hondaclient = new VehicleClient(honda, "Sports");
            Console.WriteLine(hondaclient.GetMotorcycleName());
            Console.WriteLine(hondaclient.GetScooterName());

            ITwoWheelerFactory hero = new HeroFactory();
            VehicleClient heroclient = new VehicleClient(hero, "Regular");

            Console.WriteLine("******* Hero **********");
            Console.WriteLine(heroclient.GetMotorcycleName());
            Console.WriteLine(heroclient.GetScooterName());

            heroclient = new VehicleClient(hero, "Sports");
            Console.WriteLine(heroclient.GetMotorcycleName());
            Console.WriteLine(heroclient.GetScooterName());

            Console.ReadKey();
        }
    }
}



