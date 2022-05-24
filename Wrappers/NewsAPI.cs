using System.Threading.Tasks;
using CoinStatsAPI;

class NewsAPI : BaseAPI
{
    public const string Endpoint = "/news";

    public static async Task<NewsResponse> GetNewsAsync(int fromDate, int toDate, int skip = 0, int limit = 20)
    {
        if (toDate < fromDate)
            return null;
            
        var request = new Request(BaseUrl, Endpoint);

        request.AddProperty(APIProperty.Skip, skip);
        request.AddProperty(APIProperty.Limit, limit);
        request.AddProperty(APIProperty.ToDate, toDate);
        request.AddProperty(APIProperty.FromDate, fromDate);
            
        return await GetDataAsync<NewsResponse>(request);
    }
}