using System.Net.Http;
using System.Text;
using System.Text.Json;
using Systen.Threading.Tasks;

namespace EasyProjectManagement.Client.Helpers
{
    public class HttpService : IHttpService
    {
      private readonly HttpClient httpClient;
        public HttpService(HttpClient httpclient)
        {
            this.httpClient = httpclient;
        }

        public async Task<HttpResponseMessage> Post<T>(string url, T data)
        {
            var dataJson = JsonSerializer.Serialize(data);
            var stringContent = new StringContent(dataJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, stringContent);
            
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            return new HttpResponseWrapper<object>(response.IsSuccessStatusCode, null, response);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

        }
    }
}
