using SampleClasses.Infrastructure;

namespace SampleClasses.Logic.SubLogic
{
    public class RateCalculatorExtended : IRateCalculator
    {
        private IConnection connection;
        public RateCalculatorExtended(IConnection con) 
        {
            connection = con;
            Thread.Sleep(1000);

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
