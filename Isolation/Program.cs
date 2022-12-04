using SampleClasses.Logic;
using SampleClasses.Logic.SubLogic;
using SampleClasses.Infrastructure;
using SampleClasses.Configuration;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services.AddTransient<IConfiguration, Configuration>(conf => {
            return new Configuration() { ConnectionString = "My Conneection String" };
        })
        .AddTransient<IConnection, TCPConnection>()
        .AddSingleton<IRateCalculator, RateCalculatorExtended>()
        .AddTransient<ICustomer, RetailCustomer>()
        .AddTransient<ICustomer, CorporateCustomer>())
    .Build();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"\nIteration Step: {i}");

    
    var retailCustomer = host.Services.GetServices<ICustomer>().First(o => o.GetType() == typeof(RetailCustomer));
    retailCustomer.CalculateRate();

    Console.WriteLine();

    var corporateCustomer = host.Services.GetServices<ICustomer>().First(o => o.GetType() == typeof(CorporateCustomer));
    corporateCustomer.CalculateRate();
}

