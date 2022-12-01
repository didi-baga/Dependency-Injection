using SampleClasses.Logic.SubLogic;

namespace SampleClasses.Logic
{
    public class CorporateCustomer : ICustomer
    {
        private IRateCalculator rateCalculator;
        public CorporateCustomer(IRateCalculator calculator) 
        {
            rateCalculator = calculator;
            Thread.Sleep(1000);

            Console.WriteLine("Corporate Customer was created");
        }

        public double CalculateRate()
        {
            return rateCalculator.Calculate();
        }
    }
}
