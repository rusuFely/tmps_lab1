using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class PaymentCalculator
    {
        public decimal CalculatePay(Employee employee)
        {
            Console.WriteLine("Calculating payment...");
            return employee.Salary;
        }
    }
}
