using System.Security.Cryptography.X509Certificates;

namespace SampleClasses.Infrastructure
{
    public interface IConnection
    {
        void SetConnectionString(string connectionStr);

        void Connect();

        double GetCoeficient(string clientData);

        void Disconnect();
    }
}
