using System.Collections.Generic;
using System.Threading.Tasks;
using CoinStatsAPI;

public class ExchangesAPI : BaseAPI
{
    public const string Endpoint = "/exchanges";

    public static async Task<List<string>> GetExchangesAsync()
    {
        var request = new Request(BaseUrl, Endpoint);

        var response = await GetDataAsync<ExchangeResponse>(request);

        return response.supportedExchanges;
    }
}