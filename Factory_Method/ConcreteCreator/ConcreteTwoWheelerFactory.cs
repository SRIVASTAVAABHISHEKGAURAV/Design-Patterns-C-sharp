using Factory_Method.ConcreteProduct;
using Factory_Method.Creator;
using Product;
using System;

namespace Factory_Method.ConcreteCreator
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcreteTwoWheelerFactory : TwoWheelerFactory
    {
        public override IProductFactory GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "Scooter":
                    return new Scooter(60);
                case "Motorcycle":
                    return new Motorcycle(80);
                default:
                    throw new ApplicationException(string.Format("Two Wheeler '{0}' cannot be created", Vehicle));
            }
        }

    }

}
