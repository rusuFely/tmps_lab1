using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class EmployeeWordReport : IEmployeeReportGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating WORD report...");
        }
    }
}
