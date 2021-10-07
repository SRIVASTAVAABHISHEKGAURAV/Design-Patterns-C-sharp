using System;
using System.Collections.Generic;
using System.Text;

namespace LSP_After
{
   public interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
        decimal GetBasicSalary();
    }
}
