using SampleClasses.Logic;
using SampleClasses.Logic.SubLogic;
using SampleClasses.Infrastructure;
using SampleClasses.Configuration;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services.AddTransient<IConfiguration, Configuration>( conf => { 
            return new Configuration() { ConnectionString = "My Conneection String" }; 
        })
        .AddTransient<IConnection, TCPConnection>()
        .AddTransient<IRateCalculator, RateCalculatorExtended>()
        .AddTransient<ICustomer, RetailCustomer>())
    .Build();

//var scope = host.Services.CreateScope();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"\nIteration Step: {i}");

    //var retailCustomer = scope.ServiceProvider.GetRequiredService<ICustomer>();
    var retailCustomer = host.Services.GetRequiredService<ICustomer>();

    retailCustomer.CalculateRate();
}



