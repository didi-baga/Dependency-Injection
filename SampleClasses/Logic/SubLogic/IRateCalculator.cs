namespace SampleClasses.Logic.SubLogic
{
    public interface IRateCalculator
    {
        void SetConnectionData(string ConnectionData);
        double Calculate();
    }
}
