using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoinStatsAPI;

public class NewsAPI : BaseAPI
{
    public const string Endpoint = "/news";

    public static async Task<List<NewsData>> GetNewsAsync(long fromDate = -1, long toDate = -1, int skip = 0, int limit = 20)
    {
        if (toDate < fromDate && toDate != -1)
            return null;

        if (fromDate == -1 && toDate == -1)
        {
            fromDate = (DateTimeOffset.Now - TimeSpan.FromDays(1)).ToUnixTimeMilliseconds();
            toDate =  (DateTimeOffset.Now).ToUnixTimeMilliseconds();
        }

            
        var request = new Request(BaseUrl, Endpoint);

        request.AddProperty(APIProperty.Skip, skip);
        request.AddProperty(APIProperty.Limit, limit);
        request.AddProperty(APIProperty.ToDate, toDate);
        request.AddProperty(APIProperty.FromDate, fromDate);
            
        var response = await GetDataAsync<NewsResponse>(request);
        return response.news;
    }
}