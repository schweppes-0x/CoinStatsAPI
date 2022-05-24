using System.Collections.Generic;

namespace CoinStatsAPI
{
    public class Coin
    {
        public string id { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public int rank { get; set; }
        public float price { get; set; }
        public float priceBtc { get; set; }
        public float volume { get; set; }
        public int marketCap { get; set; }
        public int availableSupply { get; set; }
        public int totalSupply { get; set; }
        public float priceChange1h { get; set; }
        public float priceChange1d { get; set; }
        public float priceChange1w { get; set; }
        public string websiteUrl { get; set; }
        public string redditUrl { get; set; }
        public string twitterUrl { get; set; }
        public List<string> exp { get; set; }
    }
}