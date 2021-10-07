using Abstract_Factory_Method.AbstractProduct;

namespace Abstract_Factory_Method.ConcreteProduct.Motorcycle
{
    /// <summary>
    /// The 'Concrete Product - Motorcycle - Sports' class
    /// </summary>
    public class SportsMotorcycle : IMotorcycle
    {
        public string Name()
        {
            return "Sports Motorcycle- {Name}";
        }
    }
}
