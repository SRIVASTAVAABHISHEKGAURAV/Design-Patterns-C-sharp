using Abstract_Factory_Method.AbstractProduct;

namespace Abstract_Factory_Method.ConcreteProduct.Motorcycle
{
    /// <summary>
    /// The 'Concrete Product - Motorcycle - Regular' class
    /// </summary>
    class RegularMotorcycle : IMotorcycle
    {
        public string Name()
        {
            return "Regular Motorcycle- {Name}";
        }
    }
}
