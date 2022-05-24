using System.Collections.Generic;
using System.Linq;

namespace CoinStatsAPI
{
    public class ChartResponse
    {
        public List<List<int>> unparsedCharts { get; set; }

        public List<Chart> Charts => unparsedCharts.Select(unparsedChart => new Chart(unparsedChart)).ToList();
    }
}