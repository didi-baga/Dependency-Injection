using SampleClasses.Configuration;

namespace SampleClasses.Infrastructure
{
    public class TCPConnection : IConnection
    {
        private readonly IConfiguration configuration;
        private string? connectionString = null;


        public void SetConnectionString(string connectionStr) => connectionString = connectionStr;

        public TCPConnection(IConfiguration conf)
        {
            configuration = conf;

            if (configuration.isSleepEnabled)
                Thread.Sleep(1000);

            if (configuration.isConsoleOutputEnabled)
                Console.WriteLine("TCP Connection was created");

            connectionString = conf.ConnectionString;
        }

        public void Connect()
        {
            if (configuration.isSleepEnabled)
                Thread.Sleep(200);

            if (connectionString is null)
                throw new Exception("Connection String is null");
        }

        public void Disconnect()
        {
            if (configuration.isSleepEnabled) 
                Thread.Sleep(200);
        }

        public double GetCoeficient(string clientData)
        {
            if (configuration.isConsoleOutputEnabled)
                Console.WriteLine($"TCPConnection.clientData = { clientData }");

            return 3.14;
        }
    }
}
