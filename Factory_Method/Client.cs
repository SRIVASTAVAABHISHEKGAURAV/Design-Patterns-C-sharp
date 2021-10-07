using Factory_Method.ConcreteCreator;
using Factory_Method.Creator;
using Product;
using System;

namespace Factory_Method
{
    /// <summary>
    /// Client
    /// </summary>
    class Client
    {
        static void Main(string[] args)
        {
            TwoWheelerFactory factory = new ConcreteTwoWheelerFactory();

            IProductFactory scooter = factory.GetVehicle("Scooter");
            scooter.Speed();

            IProductFactory Motorcycle = factory.GetVehicle("Motorcycle");
            Motorcycle.Speed();

            Console.ReadKey();
        }
    }
}