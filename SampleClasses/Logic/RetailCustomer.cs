using SampleClasses.Configuration;
using SampleClasses.Logic.SubLogic;

namespace SampleClasses.Logic
{
    public class RetailCustomer : ICustomer
    {
        private IRateCalculator rateCalculator;
        private IConfiguration configuration;
        public RetailCustomer(IRateCalculator calculator, IConfiguration conf)
        {
            rateCalculator = calculator;
            configuration = conf;

            if (configuration.isConsoleOutputEnabled)
                Console.WriteLine("Retail Customer was created");

            rateCalculator.SetConnectionData("Retail Customer");
        }

        public double CalculateRate()
        {
            return rateCalculator.Calculate();
        }
    }
}
