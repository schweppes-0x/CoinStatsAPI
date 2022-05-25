using System.Collections.Generic;

namespace CoinStatsAPI
{
    public class NewsData
    {
        public string id { get; set; }
        public long feedDate { get; set; }
        public string source { get; set; }
        public string title { get; set; }
        public bool isFeatured { get; set; }
        public string description { get; set; }
        public string imgURL { get; set; }
        public string link { get; set; }
        public string sourceLink { get; set; }
        public object reactionsCount { get; set; }
        public string shareURL { get; set; }
        public List<string> relatedCoins { get; set; }
    }
}