using SampleClasses.Logic.SubLogic;

namespace SampleClasses.Logic
{
    public class RetailCustomer : ICustomer
    {
        private IRateCalculator rateCalculator;
        public RetailCustomer(IRateCalculator calculator)
        {
            rateCalculator = calculator;

            Console.WriteLine("Retail Customer was created");
        }

        public double CalculateRate()
        {
            return rateCalculator.Calculate();
        }
    }
}
