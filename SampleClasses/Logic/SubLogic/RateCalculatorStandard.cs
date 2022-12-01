using SampleClasses.Infrastructure;

namespace SampleClasses.Logic.SubLogic
{
    public class RateCalculatorStandard
    {
        private IConnection connection;
        public RateCalculatorStandard(IConnection con)
        {
            connection = con;

            Console.WriteLine("Rate Calculator Standard was created");
        }

        public double Calculate()
        {
            double rate = 0;

            connection.Connect();

            rate = 2 * connection.GetCoeficient();

            connection.Disconnect();

            return rate;
        }
    }
}
