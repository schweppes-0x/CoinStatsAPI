using System.Collections.Generic;
using System.Threading.Tasks;
using CoinStatsAPI;

public class FiatsAPI : BaseAPI
{
    public const string Endpoint = "/fiats";

    public static async Task<List<FiatData>> GetFiatsAsync()
    {
        var request = new Request(BaseUrl, Endpoint);

        return await GetDataAsync<List<FiatData>>(request);
    }
}