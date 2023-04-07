using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class EmployeeReporter
    {
        public void EmployeeReporToConsolet(Employee employee)
        {
            Console.WriteLine($"Employee {employee.Id}");
            Console.WriteLine($"Salary: {employee.Salary}");
        }
    }
}
