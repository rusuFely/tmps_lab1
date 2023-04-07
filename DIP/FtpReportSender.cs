using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
     class FtpReportSender : IReportSender
    {

        public void SendReport(ReportProcessor report)
        {
            Console.WriteLine("Sending report via FTP...");
        }
    }
}
