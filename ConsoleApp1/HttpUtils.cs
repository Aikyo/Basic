using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace MyHttpClient
{
    public static class HttpUtils
    {
        private static readonly HttpClient HttpClient;
        static HttpUtils()
        {
            var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.None };
            HttpClient = new HttpClient(handler);
        }

        public static string GetAsync(string url)
        {
            var httpClient = HttpUtils.HttpClient;
            string s = HttpClient.GetStringAsync(url).Result;
            return s;
        }

        /// <summary>
        /// post Object return strnig
        /// </summary>
        /// <param name="url"></param>
        /// <param name="PostData"></param>
        /// <returns></returns>
        public static string Post(string url, Object PostData)
        {
            var request = JsonConvert.SerializeObject(PostData);
            HttpContent httpcontent = new StringContent(request);
            httpcontent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var httpClient = new HttpClient();
            var responsejson = httpClient.PostAsync(url, httpcontent).Result.Content.ReadAsStringAsync().Result;
            return responsejson;
        }
    }
}
