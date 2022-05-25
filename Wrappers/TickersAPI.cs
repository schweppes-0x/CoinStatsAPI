using System.Collections.Generic;
using System.Threading.Tasks;
using CoinStatsAPI;

public class TickersAPI : BaseAPI
{
    public const string Endpoint = "/tickers";

    public static async Task<List<TickerData>> GetTickersAsync(Exchange exchange = Exchange.Yobit, string pair = "BTC-USD")
    {
        var request = new Request(BaseUrl, Endpoint);
            
        request.AddProperty(APIProperty.Exchange, exchange.ToString().ToLower());
        request.AddProperty(APIProperty.Pair, pair);
            
        var response = await GetDataAsync<TickersResponse>(request);
        return response.tickers;
    }
}