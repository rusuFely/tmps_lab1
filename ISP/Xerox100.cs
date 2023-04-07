using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class Xerox100 :  IFax, IPrinter
    {
        public void Fax(string data)
        {
            Console.WriteLine("Xerox 100 is faxing: " + data);
        }

        public void Print(string data)
        {
            Console.WriteLine("Xerox 100 is printing: " + data);
        }

    }
}
