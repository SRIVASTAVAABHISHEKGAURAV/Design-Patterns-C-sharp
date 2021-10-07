using Product;
using System;

namespace Factory_Method.ConcreteProduct
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Scooter : IProductFactory
    {
        int maxSpeed = 0;
        public Scooter(int maxkm)
        {
            maxSpeed = maxkm;
        }
        public void Speed()
        {
            Console.WriteLine("Maximum Speed of the Scooter : " + maxSpeed.ToString() + " km");
        }
    }

}
