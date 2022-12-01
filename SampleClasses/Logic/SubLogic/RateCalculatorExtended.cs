using SampleClasses.Configuration;
using SampleClasses.Infrastructure;

namespace SampleClasses.Logic.SubLogic
{
    public class RateCalculatorExtended : IRateCalculator
    {
        private IConnection connection;
        private IConfiguration configuration;
        private string connectionData = "none";

        public RateCalculatorExtended(IConnection con, IConfiguration conf) 
        {
            connection = con;
            configuration = conf;

            if(configuration.isSleepEnabled)
                Thread.Sleep(1000);

            if (configuration.isConsoleOutputEnabled)
                Console.WriteLine("Rate Calculator Extended was created");
        }

        public double Calculate()
        {
            connection.Connect();

            double rate = 10 * connection.GetCoeficient(connectionData);

            connection.Disconnect();

            return rate;
        }

        public void SetConnectionData(string connData) => connectionData = connData;
    }
}
