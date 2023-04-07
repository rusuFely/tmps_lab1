using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Xerox100 xerox100 = new Xerox100();

            xerox100.Print("Hello World");
            xerox100.Fax("Hello people");
        }
    }
}