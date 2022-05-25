using System.Collections.Generic;
using System.Threading.Tasks;
using CoinStatsAPI;

public class HandPickedNewsAPI : BaseAPI
{
    public static string Endpoint => $"{NewsAPI.Endpoint}/handpicked";
    public static async Task<List<NewsData>> GetHandPickedNews(int skip = 0, int limit = 20)
    {
        var request = new Request(BaseUrl, Endpoint);

        if(skip > 0)
            request.AddProperty(APIProperty.Skip, skip);
        if(limit > 0)
            request.AddProperty(APIProperty.Limit, limit);
            
        var response = await GetDataAsync<NewsResponse>(request);
        
        return response.news;
    }
}