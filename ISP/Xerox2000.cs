using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Xerox2000 : IScanner, IFax, IPrinter
    {
        public void Fax(string data)
        {
            Console.WriteLine($"Xerox2000 is sending fax: {data}");
        }

        public void Print(string data)
        {
            Console.WriteLine($"Xerox2000 is printing: {data}");
        }

        public void Scan()
        {
            Console.WriteLine($"Xerox2000 is scanning...");
        }
    }
}
