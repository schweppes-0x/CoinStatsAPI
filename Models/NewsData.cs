using System.Collections.Generic;

namespace CoinStatsAPI
{
    internal class NewsData
    {
        public string id { get; set; }
        public int feedDate { get; set; }
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