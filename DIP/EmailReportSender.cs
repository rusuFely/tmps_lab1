using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class EmailReportSender : IReportSender
    {

        public void SendReport(ReportProcessor report)
        {
            Console.WriteLine("Sending report via Emaiol...");
        }
    }
}
