namespace SampleClasses.Infrastructure
{
    public interface IConnection
    {
        void Connect();

        double GetCoeficient();

        void Disconnect();
    }
}
