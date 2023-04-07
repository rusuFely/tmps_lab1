using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class EmployeeRepository
    {
        public Employee Save(Employee employee)
        {
            Console.WriteLine($"Saving Employee {employee.Id} to DB...");
            return employee;
        }
    }
}
