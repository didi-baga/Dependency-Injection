using SampleClasses.Logic;
using SampleClasses.Logic.SubLogic;
using SampleClasses.Infrastructure;
using SampleClasses.Configuration;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

var watch = new System.Diagnostics.Stopwatch();
watch.Start();

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services.AddTransient<IConfiguration, Configuration>(conf => {
            return new Configuration() { isSleepEnabled = false, isConsoleOutputEnabled = false,  ConnectionString = "My Conneection String" };
        })
        .AddTransient<IConnection, TCPConnection>()
        .AddTransient<IRateCalculator, RateCalculatorExtended>()
        .AddTransient<ICustomer, RetailCustomer>())
    .Build();

for (int i = 0; i < 100000000; i++)
{
    var retailCustomer = host.Services.GetRequiredService<ICustomer>();

    retailCustomer.CalculateRate();

    if (i % 100000 == 0)
        Console.WriteLine(i);
}

watch.Stop();
Console.WriteLine($"\n\nExecution Time: {watch.ElapsedMilliseconds} ms \n\n\n");