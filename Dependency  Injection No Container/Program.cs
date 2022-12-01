using SampleClasses.Logic;
using SampleClasses.Logic.SubLogic;
using SampleClasses.Infrastructure;
using SampleClasses.Configuration;

var configuration = new Configuration();
var connection = new TCPConnection(configuration);
var rateCalculatorExtended = new RateCalculatorExtended(connection, configuration);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Iteration Step: {i}");

    var retailCustomer = new RetailCustomer(rateCalculatorExtended, configuration);

    retailCustomer.CalculateRate();

    Console.WriteLine($"\n");
}
