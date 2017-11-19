namespace PerfectAbstraction
{
    public class DBConnection : IConnection
    {
        private readonly string connectionString;

        public DBConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Connect()
        {
            System.Console.WriteLine($"Connected DB to {connectionString}");
        }

        public void Disconnect()
        {
            System.Console.WriteLine($"Disconnected DB from {connectionString}");
        }
    }
}
