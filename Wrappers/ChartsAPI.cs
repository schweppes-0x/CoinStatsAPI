using System.Collections.Generic;
using System.Threading.Tasks;
using CoinStatsAPI;

public class ChartsAPI : BaseAPI
{
    public const string Endpoint = "/charts";

    public static async Task<List<Chart>> GetChartsAsync(string period = "24h", string coinId = "bitcoin")
    {
        var request = new Request(BaseUrl, Endpoint);
        
        request.AddProperty(APIProperty.Period, period);
        request.AddProperty(APIProperty.CoinId, coinId);
        
        var response = await GetDataAsync<ChartResponse>(request);
        return response.Charts;
    }
}