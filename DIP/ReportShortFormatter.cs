using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class ReportShortFormatter : IReportFormatter
    {
        public Report Format(ReportProcessor report)
        {
            Console.WriteLine("Doing some short formating...");
            return report;
        }

        public ReportProcessor Format(Report report)
        {
            throw new NotImplementedException();
        }
    }
}
