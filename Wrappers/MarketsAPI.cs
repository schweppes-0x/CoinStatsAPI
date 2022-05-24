using System.Collections.Generic;
using System.Threading.Tasks;
using CoinStatsAPI;

public class MarketsAPI : BaseAPI
{
    public const string Endpoint = "/markets";

    public static async Task<List<MarketData>> GetMarketsAsync(string coinId = "bitcoin")
    {
        var request = new Request(BaseUrl, Endpoint);
        request.AddProperty("coinId", coinId);

        return await GetDataAsync<List<MarketData>>(request);
    }
}