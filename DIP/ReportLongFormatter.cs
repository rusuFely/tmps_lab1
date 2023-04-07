using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class ReportLongFormatter : IReportFormatter
    {
        public ReportProcessor Format(Report report)
        {
            Console.WriteLine("Formating report in long format...");
            return report;
        }
    }
}
