using Abstract_Factory_Method.AbstractProduct;

namespace Abstract_Factory_Method.ConcreteProduct.Scooter
{

    /// <summary>
    /// The 'Concrete Product - Scooter - Regular' class
    /// </summary>
    public class RegularScooter : IScooter
    {
        public string Name()
        {
            return "Regular Scooter- Name";
        }
    }
}
