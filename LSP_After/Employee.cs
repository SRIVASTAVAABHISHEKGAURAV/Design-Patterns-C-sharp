using System;
using System.Collections.Generic;
using System.Text;

namespace LSP_After
{
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Employee()
        { }

        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;

        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }

        public abstract decimal GetBasicSalary();
    }

    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        { }

        public PermanentEmployee(int id, string name) : base(id, name)
        { }

        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .1M);
        }

        public override decimal GetBasicSalary()
        {
            return 15000;
        }
    }

    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        { }

        public TemporaryEmployee(int id, string name) : base(id, name)
        { }

        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .05M);
        }

        public override decimal GetBasicSalary()
        {
            return 5000;
        }
    }

    public class ContractEmployee : IEmployee
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public ContractEmployee()
        { }

        public ContractEmployee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public decimal GetBasicSalary()
        {
            return 5000;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }
}
