using SampleClasses.Configuration;
using SampleClasses.Infrastructure;

namespace SampleClasses.Logic.SubLogic
{
    public class RateCalculatorStandard
    {
        private IConnection connection;
        private IConfiguration configuration;
        private string connectionData = "none";

        public RateCalculatorStandard(IConnection con, IConfiguration conf)
        {
            connection = con;
            configuration = conf;

            if(configuration.isSleepEnabled)
                Console.WriteLine("Rate Calculator Standard was created");
        }

        public double Calculate()
        {
            connection.Connect();

            double rate = 2 * connection.GetCoeficient(connectionData);

            connection.Disconnect();

            return rate;
        }

        public void SetConnectionData(string connData) => connectionData = connData;
    }
}
