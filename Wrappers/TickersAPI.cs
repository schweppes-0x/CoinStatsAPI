using System.Threading.Tasks;
using CoinStatsAPI;

public class TickersAPI : BaseAPI
{
    public const string Endpoint = "/tickers";

    public static async Task<TickersResponse> GetTickersAsync(string exchange = "yobit", string pair = "BTC-USD")
    {
        var request = new Request(BaseUrl, Endpoint);
            
        request.AddProperty(APIProperty.Exchange, exchange);
        request.AddProperty(APIProperty.Pair, pair);
            
        return await GetDataAsync<TickersResponse>(request);
    }
}