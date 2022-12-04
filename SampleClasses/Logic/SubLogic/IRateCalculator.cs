namespace SampleClasses.Logic.SubLogic
{
    public interface IRateCalculator
    {
        void SetClientData(string clientData);

        double Calculate();
    }
}
