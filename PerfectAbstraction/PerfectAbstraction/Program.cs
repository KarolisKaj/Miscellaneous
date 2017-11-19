using System;
using System.Net;

namespace PerfectAbstraction
{
    public class Program
    {
        static void Main(string[] args)
        {
            var value = First.Value(new[] { new First<IConnection>(new DBConnection("192.168.0.1;id=jack;pw=mick")), new First<IConnection>(new TCPConnection("192.168.0.1")) });

            value.Value.Connect();
            Console.ReadKey();
        }
    }
}
