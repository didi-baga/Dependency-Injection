namespace SampleClasses.GlobalLogic
{
    public interface IAdmin
    {
        void SetConfiguration(bool isSleepEnabled, bool isConsoleOutputEnabled, string? ConnectionString);
    }
}
