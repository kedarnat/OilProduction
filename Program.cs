using System;

namespace OilProduction
{
    static class Program
    {
        private static void Main(string[] args)
        {
            switch (args.Length)
            {
                // Test if input arguments were supplied:
                case 4:
                    var isNumberOfDrills = int.TryParse(args[0], out var numberOfDrills);
                    if (isNumberOfDrills == false)
                    {
                        Console.WriteLine("Please enter a numeric argument for NumberOfDrills.");
                        Console.Read();
                        return;
                    }

                    var isDrillFinishingTime = int.TryParse(args[1], out var drillFinishingTime);
                    if (isDrillFinishingTime == false)
                    {
                        Console.WriteLine("Please enter a numeric argument for Drill finishes period.");
                        Console.Read();
                        return;
                    }


                    var isInitialOutputOfBarrels = int.TryParse(args[2], out var initialOutputOfBarrels);
                    if (isInitialOutputOfBarrels == false)
                    {
                        Console.WriteLine("Please enter a numeric argument for Initial output barrels of oil per day .");
                        Console.Read();
                        return;
                    }

                    var isDeclinesRate = int.TryParse(args[3], out var declinesRate);
                    if (isDeclinesRate == false)
                    {
                        Console.WriteLine("Please enter a numeric argument for oil well output declines rate .");
                        Console.Read();
                        return;
                    }

                    var objDrill = new Drill
                    {
                        FinishingTime = drillFinishingTime,
                        NumberOfMiningDrills = numberOfDrills,
                        DeclinesRate = declinesRate,
                        InitialOutputOfBarrels = initialOutputOfBarrels
                    };

                    Console.WriteLine("********************************Input************************************************");
                    Console.WriteLine("NumberOfDrills are [{0}].", numberOfDrills);
                    Console.WriteLine("Drill finishes in [{0}] hours period.", drillFinishingTime);
                    Console.WriteLine("Initial output of [{0}] barrels of oil per day.", initialOutputOfBarrels);
                    Console.WriteLine("Each day the oil well output declines linearly by a fixed rate of [{0}].", declinesRate);
                    Console.WriteLine("********************************Result************************************************");
                    Console.WriteLine("**************************************************************************************");
                    Console.WriteLine("Parllel Drilling Maximum production can reach at {0} hours.", objDrill.ParllelDrillMaximumProduction());
                    Console.WriteLine("Sequential Drilling Maximum production can reach at {0} hours.", objDrill.SequentialDrillMaximumProduction());
                    Console.WriteLine("Parllel Drilling company's peak daily oil production is {0} barrels.", objDrill.ParllelDailyOilProduction());
                    Console.WriteLine("Sequential Drilling company's peak daily oil production is {0} barrels.", objDrill.SequentialDailyOilProduction());
                    Console.WriteLine("**************************************************************************************");
                    Console.Read();
                    break;
                case 0:
                    Console.WriteLine("Please enter a numeric argument.");
                    Console.WriteLine("Usage: OilProduction <NumberOfDrills> <Period> <InitialOutputBarrels> <declineRate>");
                    Console.Read();
                    break;
            }
        }

    }
}
