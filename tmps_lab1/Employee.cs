using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class Employee
    {
        public long Id { get; private set;  }  

        public decimal Salary { get; private set; }

        public Employee(long id, decimal salary)
        {
            Id = id;
            Salary = salary;
        }
    }
}
