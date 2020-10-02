using System;
using System.Net.Http;
using System.Threading.Tasks;
using ERP.Web.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace ERP.Web.Helpers
{
    public interface IAPIHelper
    {
        Task<T> Get<T>(string partUrl);
        Task<U> Post<T,U>(string partUrl,T postData);
    }
    public class APIHelper:IAPIHelper
    {
        private HttpClient _client;
        private readonly IOptions<ConfigurationSettings> configuration;
        private string baseUrl;
        public APIHelper(IOptions<ConfigurationSettings> config)
        {
            configuration=config;
            //baseUrl=config.Value.APIUrl;
            //baseUrl = "http://192.168.8.101:19558/api/";
            baseUrl = "http://localhost:44312/api/";
            _client =new HttpClient();
        }

        public async Task<T> Get<T>(string partUrl)
        {
            HttpResponseMessage response = await _client.GetAsync(baseUrl+partUrl);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsAsync<T>();
                return result;
            }
            else{
                throw new Exception("Failed");
            }
        }

        public async Task<U> Post<T,U>(string partUrl,T postData)
        {
            try
            {
                var response = await _client.PostAsJsonAsync(
                        baseUrl+partUrl, postData);
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsAsync<U>().Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}