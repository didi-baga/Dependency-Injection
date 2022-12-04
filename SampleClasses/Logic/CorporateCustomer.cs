using SampleClasses.Configuration;
using SampleClasses.Logic.SubLogic;

namespace SampleClasses.Logic
{
    public class CorporateCustomer : ICustomer
    {
        private IRateCalculator rateCalculator;
        private IConfiguration configuration;

        public CorporateCustomer(IRateCalculator calculator, IConfiguration conf) 
        {
            rateCalculator = calculator;
            configuration = conf;

            if(configuration.isSleepEnabled)
                Thread.Sleep(1000);

            if (configuration.isConsoleOutputEnabled)
                Console.WriteLine("Corporate Customer was created");

            rateCalculator.SetClientData("Corporate Customer");
        }

        public double CalculateRate()
        {
            return rateCalculator.Calculate();
        }
    }
}
