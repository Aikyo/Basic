using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class HttpUtils
    {
        private const string userAgen = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36";
        /// <summary>
        /// post Object return string
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
            return responsejson.ToString();
        }


        public static string Get(string url)
        {
            HttpClient httpClient = new HttpClient(new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip });
            HttpResponseMessage response = null;

            try
            {
                httpClient.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));
#pragma warning disable CA2234 // Pass system uri objects instead of strings
                Task<HttpResponseMessage> taskResponse = httpClient.GetAsync(url);
#pragma warning restore CA2234 // Pass system uri objects instead of strings
                taskResponse.Wait();
                response = taskResponse.Result;

                if (response.IsSuccessStatusCode)
                {
                    Task<System.IO.Stream> taskStream = response.Content.ReadAsStreamAsync();
                    taskStream.Wait();
                    System.IO.Stream dataStream = taskStream.Result;
                    System.IO.StreamReader reader = new System.IO.StreamReader(dataStream);
                    string result = reader.ReadToEnd();

                    return result;
                }
                return null;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (response != null)
                {
                    response.Dispose();
                }
                if (httpClient != null)
                {
                    httpClient.Dispose();
                }
            }

        }
    }
}
