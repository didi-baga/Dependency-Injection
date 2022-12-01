using SampleClasses.Configuration;
using SampleClasses.Infrastructure;

namespace SampleClasses.Logic.SubLogic
{
    public class RateCalculatorExtended : IRateCalculator
    {
        private IConnection connection;
        private IConfiguration configuration;

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
            double rate = 0;

            connection.Connect();

            rate = 10 * connection.GetCoeficient();

            connection.Disconnect();

            return rate;
        }
    }
}
