using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string data)
        {
            Console.WriteLine("Logging to console" + data);
        }
    }
}
