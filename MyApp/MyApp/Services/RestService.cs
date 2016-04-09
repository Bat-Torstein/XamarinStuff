using MyApp.Models;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using MyApp.Services;

[assembly: Dependency(typeof(RestService))]
namespace MyApp.Services
{
    public class RestService : IRestService
    {
        public RestService()
        {
        }

        HttpClient CreateClient()
        {
            return new HttpClient();
        }

        // Remember that Emulators/Devices cannot use localhost
        const string GetItemUrl = @"http://someurl/api/item/{0}";

        public async Task<MyModel> GetItem(string id)
        {
            var client = CreateClient();

            var request = string.Format(GetItemUrl, id);
            var response = await client.GetStringAsync(request);

            return DeserializeObject<MyModel>(response);
        }

        public Task<T> DeserializeObjectAsync<T>(string value)
        {
            return Task.Factory.StartNew(() => JsonConvert.DeserializeObject<T>(value));
        }

        public T DeserializeObject<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }
    }
}
