using Abstract_Factory_Method.AbstractFactory;
using Abstract_Factory_Method.AbstractProduct;
using Abstract_Factory_Method.ConcreteProduct.Motorcycle;
using Abstract_Factory_Method.ConcreteProduct.Scooter;
using System;

namespace Abstract_Factory_Method.ConcreteFactory
{
    /// <summary>
    /// The 'ConcreteFactory2' class.
    /// </summary>
    public class HeroFactory : ITwoWheelerFactory
    {
        public IMotorcycle GetMotorcycle(string Motorcycle)
        {
            switch (Motorcycle)
            {
                case "Sports":
                    return new SportsMotorcycle();
                case "Regular":
                    return new RegularMotorcycle();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Motorcycle));
            }

        }

        public IScooter GetScooter(string Scooter)
        {
            switch (Scooter)
            {
                case "Sports":
                    return new Scooty();
                case "Regular":
                    return new RegularScooter();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Scooter));
            }

        }
    }
}
