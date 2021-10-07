using System.Linq;

namespace LSP.After
{
    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers)
            : base(numbers)
        {
        }

        public override int Calculate() => _numbers.Sum();
    }

}
