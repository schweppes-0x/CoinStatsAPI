using System.Collections.Generic;
using System.Threading.Tasks;
using CoinStatsAPI;
using CoinStatsAPI.Models;

public class CoinsAPI : BaseAPI
{
    public const string EndPoint = "/coins";

    public static async Task<List<Coin>> GetCoinsAsync(int skip = 0, int limit = 0, Fiat currency = Fiat.EUR)
    {
        var request = new Request(BaseUrl, EndPoint);
            
        request.AddProperty(APIProperty.Skip, skip);
        request.AddProperty(APIProperty.Limit, limit);
        request.AddProperty(APIProperty.Currency, currency.ToString().ToUpper());

        var response = await GetDataAsync<CoinApiResponse>(request);
        
        return response.coins;
    }
        
}