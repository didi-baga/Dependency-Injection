namespace SampleClasses.Configuration
{
    public interface IConfiguration
    {
        bool isSleepEnabled { get; set; }

        bool isConsoleOutputEnabled { get; set; }
    }
}
