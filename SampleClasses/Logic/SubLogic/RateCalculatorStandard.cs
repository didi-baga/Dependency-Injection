﻿using SampleClasses.Configuration;
using SampleClasses.Infrastructure;

namespace SampleClasses.Logic.SubLogic
{
    public class RateCalculatorStandard
    {
        private IConnection connection;
        private IConfiguration configuration;

        public RateCalculatorStandard(IConnection con, IConfiguration conf)
        {
            connection = con;
            configuration = conf;

            if(configuration.isSleepEnabled)
                Console.WriteLine("Rate Calculator Standard was created");
        }

        public double Calculate()
        {
            double rate = 0;

            connection.Connect();

            rate = 2 * connection.GetCoeficient();

            connection.Disconnect();

            return rate;
        }
    }
}