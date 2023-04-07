using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class EmployeeExcelReport : IEmployeeReportGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating EXCEL report...");
        }
    }
}
