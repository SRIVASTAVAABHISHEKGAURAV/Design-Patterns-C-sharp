using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empPermanent = new PermanentEmployee(1, "Permanent");
            Employee empTemporary = new TemporaryEmployee(2, "Temporary");
            Employee empContract = new ContractEmployee(3, "Contract");

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}", empPermanent.ToString(), empPermanent.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}", empTemporary.ToString(), empTemporary.CalculateBonus(150000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}", empContract.ToString(),  empContract.CalculateBonus(150000).ToString()));

            Console.ReadLine();
        }
    }
}
