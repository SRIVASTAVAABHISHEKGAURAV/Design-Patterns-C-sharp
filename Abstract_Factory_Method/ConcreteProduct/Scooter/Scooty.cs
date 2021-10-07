using Abstract_Factory_Method.AbstractProduct;

namespace Abstract_Factory_Method.ConcreteProduct.Scooter
{
    /// <summary>
    /// The 'Concrete Product - Scooter - Scooty' class
    /// </summary>
    class Scooty : IScooter
    {
        public string Name()
        {
            return "Scooty- Name";
        }
    }

}
