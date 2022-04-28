using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Classroom.Client.HttpService
{
    public class HttpHelper
    { 
        public readonly HttpClient _client;

        public HttpHelper()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:44300/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> POST(object obj, string url)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            var apiResponse = await _client.PostAsync(url, stringContent);
            var a =  await  apiResponse.Content.ReadAsStringAsync();
            return a;
        }

        public async Task<string> GET(string url)
        {
            //var stringContent = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            var apiResponse = await _client.GetAsync(url);
            var a = await apiResponse.Content.ReadAsStringAsync();
            return a;
        }

        public async Task<string> PUT(object obj, string url)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            var apiResponse = await _client.PutAsync(url, stringContent);
            var a = await apiResponse.Content.ReadAsStringAsync();
            return a;
        }

        public async Task<string> DELETE(string url)
        {
            var apiResponse = await _client.DeleteAsync(url);
            var a = await apiResponse.Content.ReadAsStringAsync();
            return a;
        }

        public async Task<string> POSTforFile(MultipartFormDataContent obj, string url)
        {
            //var stringContent = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            var apiResponse = await _client.PostAsync(url, obj);
            var a = await apiResponse.Content.ReadAsStringAsync();
            return a;
        }
    }
}
