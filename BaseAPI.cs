using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace CoinStatsAPI
{
    public abstract class BaseAPI
    {
        public const string BaseUrl = "https://api.coinstats.app/public/v1";
        public static async Task<T> GetDataAsync<T>(string url)
        {
            var response = await new HttpClient().GetAsync(url);
            
            response.EnsureSuccessStatusCode();
                
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync(), new JsonSerializerSettings { 
                NullValueHandling = NullValueHandling.Ignore
            });
        }

        public static async Task<T> GetDataAsync<T>(Request request)
        {
            return await GetDataAsync<T>(request.FinalUrl);
        }
    }
}