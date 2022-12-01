namespace SampleClasses.Infrastructure
{
    public class TCPConnection : IConnection
    {
        public TCPConnection()
        {
            Thread.Sleep(1000);
            Console.WriteLine("TCP Connection was created");
        }

        public void Connect()
        {
            Thread.Sleep(200);
        }

        public void Disconnect()
        {
            Thread.Sleep(200);
        }

        public double GetCoeficient()
        {
            return 3.14;
        }
    }
}
