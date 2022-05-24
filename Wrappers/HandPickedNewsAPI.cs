using System.Threading.Tasks;
using CoinStatsAPI;

class HandPickedNewsAPI : BaseAPI
{
    public static string Endpoint => $"{NewsAPI.Endpoint}/handpicked";

    public static async Task<HandPickedNewsResponse> GetHandPickedNews(int skip = 0, int limit = 20)
    {
        var request = new Request(BaseUrl, Endpoint);

        request.AddProperty(APIProperty.Skip, skip);
        request.AddProperty(APIProperty.Limit, limit);
            
        return await GetDataAsync<HandPickedNewsResponse>(request);
    }
}