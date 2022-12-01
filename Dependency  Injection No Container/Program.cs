using SampleClasses.Logic;
using SampleClasses.Logic.SubLogic;
using SampleClasses.Infrastructure;


var connection = new TCPConnection();
var rateCalculatorExtended = new RateCalculatorExtended(connection);

for (int i = 0; i < 10; i++)
{
    var retailCustomer = new RetailCustomer(rateCalculatorExtended);

    retailCustomer.CalculateRate();
}
