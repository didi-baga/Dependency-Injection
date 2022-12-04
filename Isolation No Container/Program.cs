using SampleClasses.Logic;
using SampleClasses.Logic.SubLogic;
using SampleClasses.Infrastructure;
using SampleClasses.Configuration;

var configuration = new Configuration() { ConnectionString = "My Conneection String" };
var connection = new TCPConnection(configuration);
var rateCalculatorExtended = new RateCalculatorExtended(connection, configuration);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"\nIteration Step: {i}");

    var retailCustomer = new RetailCustomer(rateCalculatorExtended, configuration);

    retailCustomer.CalculateRate();

    Console.WriteLine();

    var corporateCustomer = new CorporateCustomer(rateCalculatorExtended, configuration);

    corporateCustomer.CalculateRate();
}
