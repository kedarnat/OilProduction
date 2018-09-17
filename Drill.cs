namespace OilProduction
{
    public class Drill
    {
        public int NumberOfMiningDrills { private get; set; }
        public int FinishingTime { private get; set; }
        public int InitialOutputOfBarrels { private get; set; }
        public int DeclinesRate { private get; set; }

        public int ParllelDrillMaximumProduction()
        {
            return FinishingTime;
        }

        public int SequentialDrillMaximumProduction()
        {
            return NumberOfMiningDrills * FinishingTime;
        }

        public double SequentialDailyOilProduction()
        {
            return (double)(InitialOutputOfBarrels)/ DeclinesRate;
        }

        public double ParllelDailyOilProduction()
        {
            return (double)(InitialOutputOfBarrels * NumberOfMiningDrills) / DeclinesRate;
        }
    }
}
