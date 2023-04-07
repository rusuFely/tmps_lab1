using System;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OCP;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            var reports = new List<IEmployeeReportGenerator>();
            reports.Add(new EmployeePdfReport());
            reports.Add(new EmployeeWordReport());
            reports.Add(new EmployeeExcelReport());

            foreach (var report in reports)
                report.GenerateReport();

        }
    }
}