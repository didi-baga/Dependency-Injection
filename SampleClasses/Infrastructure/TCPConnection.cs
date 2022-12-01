using SampleClasses.Configuration;

namespace SampleClasses.Infrastructure
{
    public class TCPConnection : IConnection
    {
        private IConfiguration configuration;

        public TCPConnection(IConfiguration conf)
        {
            configuration = conf;

            if(configuration.isSleepEnabled)
                Thread.Sleep(1000);

            if (configuration.isConsoleOutputEnabled)
                Console.WriteLine("TCP Connection was created");
        }

        public void Connect()
        {
            if (configuration.isSleepEnabled)
                Thread.Sleep(200);
        }

        public void Disconnect()
        {
            if (configuration.isSleepEnabled) 
                Thread.Sleep(200);
        }

        public double GetCoeficient()
        {
            return 3.14;
        }
    }
}
