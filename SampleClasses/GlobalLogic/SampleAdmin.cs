using SampleClasses.Configuration;

namespace SampleClasses.GlobalLogic
{
    internal class SampleAdmin : IAdmin
    { 
        private readonly IConfiguration configuration;

        public SampleAdmin(IConfiguration conf) => configuration = conf;

        public void SetConfiguration(bool isSleepEnabled, bool isConsoleOutputEnabled, string? ConnectionString)
        {
            configuration.ConnectionString = ConnectionString;
            configuration.isConsoleOutputEnabled= isConsoleOutputEnabled;
            configuration.isSleepEnabled= isSleepEnabled;
        }
    }
}
