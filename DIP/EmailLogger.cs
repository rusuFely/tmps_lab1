using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class EmailLogger : ILogger
    {
        public void Log(string data)
        {
            Console.WriteLine("Logging via email" + data);
        }
    }
}
