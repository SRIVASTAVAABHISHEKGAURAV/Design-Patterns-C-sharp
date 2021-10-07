using Abstract_Factory_Method.AbstractProduct;

namespace Abstract_Factory_Method.AbstractFactory
{
    /// <summary>
    /// The 'AbstractFactory' interface. 
    /// </summary>
    public interface ITwoWheelerFactory
    {
        IMotorcycle GetMotorcycle(string Motorcycle);
        IScooter GetScooter(string Scooter);
    }
}