using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    abstract class ReportableEmployee : Employee
    {
        public abstract void ReportWork();
    }
}
