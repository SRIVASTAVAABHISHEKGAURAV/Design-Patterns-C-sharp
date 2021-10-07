using Product;
using System;

namespace Factory_Method.ConcreteProduct
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Motorcycle : IProductFactory
    {
        int maxSpeed = 0;
        public Motorcycle(int maxkm)
        {
            maxSpeed = maxkm;
        }

        public void Speed()
        {
            Console.WriteLine("Maximum Speed of the Motorcycle : " + maxSpeed.ToString() + " km");
        }
    }

}
