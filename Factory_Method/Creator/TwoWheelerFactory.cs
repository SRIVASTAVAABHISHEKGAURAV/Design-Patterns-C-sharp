using Product;

namespace Factory_Method.Creator
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class TwoWheelerFactory
    {
        public abstract IProductFactory GetVehicle(string Vehicle);

    }
}
