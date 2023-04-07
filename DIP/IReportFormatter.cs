using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
     interface IReportFormatter
    {
        ReportProcessor Format(Report report);
        object Format(ReportProcessor report);
    }
}
