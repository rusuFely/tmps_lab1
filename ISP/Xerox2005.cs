using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Xerox2005 : IScanner, IPrinter
    {

        public void Print(string data)
        {
            Console.WriteLine("Xerox 2005 printing data: " + data);
        }

        public void Scan()
        {
            Console.WriteLine("Xerox 2005 scanning...");
        }
    }
}
