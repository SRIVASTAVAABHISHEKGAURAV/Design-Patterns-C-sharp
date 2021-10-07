//using LSP.Before;
using LSP.After;
using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LSP Before
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //SumCalculator _evenSum = new EvenNumbersSumCalculator(numbers);
            //Console.WriteLine($"The sum of all the even numbers: {_evenSum.Calculate()}");

            #endregion

            #region LSP After

            Calculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");

            Calculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");

            #endregion
        }
    }
}
