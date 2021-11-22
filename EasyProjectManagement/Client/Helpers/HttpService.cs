using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace EasyProjectManagement.Client.Helpers
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient httpClient;
        public HttpService(HttpClient httpclient)
        {
            this.httpClient = httpclient;
        }

        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T data)
        {
            var dataJson = JsonSerializer.Serialize(data);
            var stringContent = new StringContent(dataJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, stringContent);

            return new HttpResponseWrapper<object>(null, response.IsSuccessStatusCode, response);

        }
    }
}
