using System.Threading.Tasks;
using CoinStatsAPI;

public class FiatsAPI : BaseAPI
{
    public const string Endpoint = "/fiats";

    public static async Task<FiatResponse> GetFiatsAsync()
    {
        var request = new Request(BaseUrl, Endpoint);

        return await GetDataAsync<FiatResponse>(request);
    }
}