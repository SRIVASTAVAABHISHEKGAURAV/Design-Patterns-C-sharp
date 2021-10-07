using System;

namespace Design_Patterns
{
    /// <summary>
    /// The 'Product' interface
    /// </summary>
    public interface IProductFactory
    {
        void Drive(int miles);
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Scooter : IProductFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
        }
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    public class Motorcycle : IProductFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the Motorcycle : " + miles.ToString() + "km");
        }
    }

    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class TwoWheelerFactory
    {
        public abstract IProductFactory GetVehicle(string Vehicle);

    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcreteVehicleFactory : TwoWheelerFactory
    {
        public override IProductFactory GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Motorcycle":
                    return new Motorcycle();
                default:
                    throw new ApplicationException(string.Format("Two Wheeler '{0}' cannot be created", Vehicle));
            }
        }

    }

    /// <summary>
    /// Factory Pattern Demo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            TwoWheelerFactory factory = new ConcreteVehicleFactory();

            IProductFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IProductFactory Motorcycle = factory.GetVehicle("Motorcycle");
            Motorcycle.Drive(20);

            Console.ReadKey();
        }
    }
}