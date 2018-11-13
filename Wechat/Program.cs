using HCHttpClient;
using System;

namespace Wechat
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=APPID&secret=APPSECRET";
            string appId = "wxe182f858608e70cb";
            string screte = "d480baa4e3c9b86763a0fa0eb2ce72db";
            string enCodingKey = "cesNuBk1dlQ52WOJ0PlmWPSP9Fp3grvXKQh8ftOtWoM";
            string result =  HttpClientHelper.GetResponse("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=" + appId+"&secret="+screte);
            Console.WriteLine(result);
        }
    }
}
