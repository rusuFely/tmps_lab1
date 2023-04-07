using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
     class SeniorDeveloper : ReportableEmployee
    {
        public override void PrintDetails()
        {
            Console.WriteLine("Printing Senior Employee Details...");
        }

        public override void ReportWork()
        {
            Console.WriteLine("Reporting Senior Work...");
        }
    }
}
