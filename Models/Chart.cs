using System.Collections.Generic;

namespace CoinStatsAPI
{
    public class Chart
    {
        public Chart(List<int> charts)
        {
            TimeStamp = charts[0];
            CurrentPrice = charts[1];
            PriceInBTC = charts[2];
            PriceInETH = charts[3];
        }
        
        public int TimeStamp { get; set; }
        public float CurrentPrice { get; set; }
        public float PriceInBTC { get; set; }
        public float PriceInETH { get; set; }
    }
}