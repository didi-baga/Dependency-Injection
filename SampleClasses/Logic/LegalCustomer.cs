using SampleClasses.Logic.SubLogic;

namespace SampleClasses.Logic
{
    public class LegalCustomer : ICustomer
    {
        private IRateCalculator rateCalculator;
        public LegalCustomer(IRateCalculator calculator)
        {
            rateCalculator = calculator;
            Thread.Sleep(500);

            Console.WriteLine("Legal Customer was created");
        }

        public double CalculateRate()
        {
            return rateCalculator.Calculate();
        }
    }
}
