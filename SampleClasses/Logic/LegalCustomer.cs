using SampleClasses.Configuration;
using SampleClasses.Logic.SubLogic;

namespace SampleClasses.Logic
{
    public class LegalCustomer : ICustomer
    {
        private IRateCalculator rateCalculator;
        private IConfiguration configuration;
        public LegalCustomer(IRateCalculator calculator, IConfiguration conf)
        {
            rateCalculator = calculator;
            configuration = conf;

            if(configuration.isSleepEnabled)
                Thread.Sleep(500);

            if (configuration.isConsoleOutputEnabled)
                Console.WriteLine("Legal Customer was created");

            rateCalculator.SetConnectionData("Legal Customer");
        }

        public double CalculateRate()
        {
            return rateCalculator.Calculate();
        }
    }
}
