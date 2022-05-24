using System.Threading.Tasks;
using CoinStatsAPI;

public class ExchangeAPI : BaseAPI
{
    public const string Endpoint = "/exchanges";

    public static async Task<ExchangeResponse> GetExchangesAsync()
    {
        var request = new Request(BaseUrl, Endpoint);

        return await GetDataAsync<ExchangeResponse>(request);
    }
}