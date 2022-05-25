using System.Collections.Generic;
using System.Linq;

namespace CoinStatsAPI
{
    public class ChartResponse
    {
        public List<List<object>> chart { get; set; }

        public List<Chart> Charts => chart.Select(unparsed => new Chart(unparsed)).ToList();
    }
}