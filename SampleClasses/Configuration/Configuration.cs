namespace SampleClasses.Configuration
{
    public class Configuration : IConfiguration
    {
        public bool isSleepEnabled { get; set; } = true;

        public bool isConsoleOutputEnabled { get; set; } = true;

        public string? ConnectionString { get; set; } = null;
    }
}
