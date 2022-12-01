using SampleClasses.Logic;
using SampleClasses.Logic.SubLogic;
using SampleClasses.Infrastructure;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services.AddTransient<IConnection, TCPConnection>()
        .AddTransient<IRateCalculator, RateCalculatorExtended>()
        .AddSingleton<ICustomer, RetailCustomer>())
    .Build();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Iteration Step: {i}");

    var retailCustomer = host.Services.GetRequiredService<ICustomer>();

    retailCustomer.CalculateRate();

    Console.WriteLine($"\n");
}



