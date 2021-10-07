using Abstract_Factory_Method.AbstractFactory;
using Abstract_Factory_Method.AbstractProduct;

namespace Abstract_Factory_Method.Client
{
    /// <summary>
    /// The 'Client' class 
    /// </summary>
    public class VehicleClient
    {
        IMotorcycle Motorcycle;
        IScooter scooter;

        public VehicleClient(ITwoWheelerFactory factory, string type)
        {
            Motorcycle = factory.GetMotorcycle(type);
            scooter = factory.GetScooter(type);
        }

        public string GetMotorcycleName()
        {
            return Motorcycle.Name();
        }

        public string GetScooterName()
        {
            return scooter.Name();
        }

    }

}
