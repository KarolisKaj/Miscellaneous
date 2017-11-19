using System.Net;

namespace PerfectAbstraction
{
    public class TCPConnection : IConnection
    {
        private readonly string endPoint;

        public TCPConnection(string endPoint)
        {
            this.endPoint = endPoint;
        }

        public void Connect()
        {
            System.Console.WriteLine($"Connected to endpoint {endPoint}");
        }

        public void Disconnect()
        {
            System.Console.WriteLine($"Disconnected from endpoint {endPoint}");
        }
    }
}
