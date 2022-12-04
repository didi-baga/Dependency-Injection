using SampleClasses.Logic;
using SampleClasses.Logic.SubLogic;
using SampleClasses.Infrastructure;
using SampleClasses.Configuration;


var watch = new System.Diagnostics.Stopwatch();
watch.Start();


for (int i = 0; i < 100000000; i++)
{
    var configuration = new Configuration() { isSleepEnabled = false, isConsoleOutputEnabled = false, ConnectionString = "My Conneection String" };
    var connection = new TCPConnection(configuration);
    var rateCalculatorExtended = new RateCalculatorExtended(connection, configuration);

    var retailCustomer = new RetailCustomer(rateCalculatorExtended, configuration);

    retailCustomer.CalculateRate();

    if (i % 100000 == 0)
        Console.WriteLine(i);
}

watch.Stop();
Console.WriteLine($"\n\nExecution Time: {watch.ElapsedMilliseconds} ms \n\n\n");