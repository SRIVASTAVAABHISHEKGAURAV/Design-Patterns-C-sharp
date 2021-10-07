using System;
using System.Collections.Generic;

namespace LSP_After
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "empPermanent"));
            employees.Add(new TemporaryEmployee(2, "empTemporary"));
            //Un Comment to see the error
            //employees.Add(new ContractEmployee(3, "empContract"));
            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus: {1} Basic Salary: {2}",
                employee.ToString(),
                employee.CalculateBonus(100000).ToString(),
                employee.GetBasicSalary().ToString()));
            }

            Console.WriteLine();

            List<IEmployee> employeesOnly = new List<IEmployee>();

            employeesOnly.Add(new PermanentEmployee(1, "empPermanent"));
            employeesOnly.Add(new TemporaryEmployee(2, "empTemporary"));
            employeesOnly.Add(new ContractEmployee(3, "empContract"));

            foreach (var employee in employeesOnly)
            {
                Console.WriteLine(string.Format("Employee {0}  Basic Salary: {1}",
                employee.ToString(),
                employee.GetBasicSalary().ToString()));
            }
            Console.ReadLine();
        }
    }
}
