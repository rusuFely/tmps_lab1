using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(473, 17231);
            PaymentCalculator paymentCalculator = new PaymentCalculator();
            EmployeeRepository employeeRepository = new EmployeeRepository();
            EmployeeReporter employeeReporter = new EmployeeReporter();

            paymentCalculator.CalculatePay(employee);
            employeeReporter.EmployeeReporToConsolet(employee);
            employeeRepository.Save(employee);
    
        
        }
    }
}
