using System;
using System.Collections.Generic;

namespace CoinStatsAPI
{
    public class Chart
    {
        public Chart(List<object> charts)
        {
            TimeStamp = Convert.ToInt32(charts[0]);
            CurrentPrice = Convert.ToDouble(charts[1]);
            PriceInBTC = Convert.ToDouble(charts[2]);
            PriceInETH = Convert.ToDouble(charts[3]);
        }
        
        public int TimeStamp { get; }
        public double CurrentPrice { get;  }
        public double PriceInBTC { get;  }
        public double PriceInETH { get;  }
    }
}