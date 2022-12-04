using SampleClasses.Logic;
using SampleClasses.Logic.SubLogic;
using SampleClasses.Infrastructure;
using SampleClasses.Configuration;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SampleClasses.GlobalLogic;

/// <summary>
/// This code sample violates Explicit Dependencies Principle  
/// for more info read this article  https://deviq.com/principles/explicit-dependencies-principle
/// </summary>


using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services.AddSingleton<IConfiguration, Configuration>()
        .AddTransient<IAdmin, SampleAdmin>()
        .AddTransient<IConnection, TCPConnection>()
        .AddTransient<IRateCalculator, RateCalculatorExtended>()
        .AddTransient<ICustomer, RetailCustomer>())
    .Build();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"\nIteration Step: {i}");

    var sampleAdmin = host.Services.GetRequiredService<IAdmin>();
    sampleAdmin.SetConfiguration(true, true, "My Conneection String");

    var retailCustomer = host.Services.GetRequiredService<ICustomer>();

    retailCustomer.CalculateRate();
}



