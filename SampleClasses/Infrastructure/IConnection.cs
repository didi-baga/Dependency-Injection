namespace SampleClasses.Infrastructure
{
    public interface IConnection
    {
        void Connect();

        double GetCoeficient(string ConnectionData);

        void Disconnect();
    }
}
