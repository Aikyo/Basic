using System;
using System.Collections.Generic;
using System.Text;

namespace httpClient
{
    class yuan1 { }
    
//        using System;
//using System.Text.RegularExpressions;
//using System.Collections.Generic;
//using System.Net.Http;
//using System.Threading.Tasks;
//using System.Net;
//using System.Threading;
//using Newtonsoft.Json;
//using System.IO;
//using System.Text;

//namespace ConsoleApp1
//    {
        //class Program
        //{
        //    static void Main(string[] args)
        //    {

        //        Dictionary<int, string> a = new Dictionary<int, string>() { };
        //        a.Add(1, "jannifer");
        //        a.Add(2, "jan");
        //        a.Add(3, "annifer");
        //        a.Add(4, "fer");
        //        //string t = "";
        //        string i = "";
        //        a.TryGetValue(2, out i);
        //        Console.WriteLine(i);

        //        //發短信
        //        PostData test = new PostData();
        //        test.ReceiverPhone = "18838934356";
        //        test.SMSContent = "hello i am kiko";
        //        test.SenderID = "1";
        //        test.SenderName = "11";
        //        test.SenderName = "herman";
        //        test.ReceiverName = "herman";
        //        //SmsResult result = HttpClient.PostResponse<SmsResult>("http://192.168.10.144:8018/api/SMS/SendSMS", test);
        //        //Console.WriteLine(result.isSuccess);
        //        // http://192.168.10.144:8018/api/SMS/SendSMS?receiverPhone=18838934356

        //        ////httpClient
        //        //HttpClient client = new HttpClient();
        //        //HttpResponseMessage response = await client.GetAsync("http://192.168.10.120:8021/Api/Examination/product?productId=TC201604081442440001");
        //        //response.EnsureSuccessStatusCode();
        //        //string responseBody = await response.Content.ReadAsStringAsync();
        //        //Console.WriteLine(responseBody);

        //        //GetResponse();
        //        string result1 = httpClient("http://192.168.10.144:8018");
        //        Console.WriteLine(result1);
        //    }

        //    //http://192.168.10.144:8018
        //    //httpclient 
        //    public static string httpClient(string url)
        //    {
        //        try
        //        {
        //            HttpClient client = new HttpClient();
        //            client.BaseAddress = new Uri(url);

        //            var content = new FormUrlEncodedContent(new[] {
        //            new KeyValuePair<string, string>("clientNumber", "18838934356"),
        //            new KeyValuePair<string,string>("senderName","hello iam kiko"),
        //            new KeyValuePair<string, string>("senderID", "18838934356"),
        //            new KeyValuePair<string,string>("receiverName","hello iam kiko"),
        //            new KeyValuePair<string, string>("receiverPhone", "18838934356"),
        //            new KeyValuePair<string,string>("smsContent","亲爱的{CustomerName}，你的{ProductName}已预约成功！体检时间：{Time}，体检门店：{ShopName}。地址：{ShopAddress}。请按时前往体检门店进行体检！") });
        //            var result = client.PostAsync("/api/SMS/SendSMS", content).Result;
        //            var stringresult = result.Content.ReadAsStringAsync().Result;
        //            return stringresult + "httpClient";
        //        }
        //        catch (Exception e)
        //        {
        //            return null;
        //        }


        //    }

        //    // 建立stream 流
        //    public static string PostResponse()
        //    {
        //        ////send messages step1 
        //        string url = "http://192.168.10.144:8018/api/SMS/SendSMS";
        //        WebRequest request = WebRequest.Create(url);
        //        request.Method = "POST";

        //        //post argument
        //        string postdata = "receiverPhone=18838934356&receiverName=herman";
        //        Byte[] bytes = System.Text.Encoding.ASCII.GetBytes(postdata);
        //        request.ContentType = "applicaiton/json";
        //        request.ContentLength = postdata.Length;
        //        Stream Send = request.GetRequestStream();//建立连接 ASCII流
        //        Send.Write(bytes, 0, bytes.Length);
        //        Send.Close();

        //        WebResponse response = request.GetResponse();
        //        string response1 = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8")).ReadToEnd();
        //        Console.WriteLine(response1);
        //        return response1;
        //    }

        //    public void RegularExpression()
        //    {
        //        //select {}
        //        string s = "i {the Mather fucker} am {jannifer} {kiko} {akali}!!";
        //        Regex reg = new Regex(@"\{(.*?)\}");

        //        string msg = "你aaa好aa哈哈a";
        //        msg = Regex.Replace(msg, @"a+", "A");
        //        Console.WriteLine(msg);
        //        Console.WriteLine("");



        //        string st = "{a}{b}";
        //        // st.Replace("{a}", "c");
        //        st = Regex.Replace(st, "{a}", "c");
        //        st = Regex.Replace(st, "{b}", "d");
        //        Console.WriteLine(st);
        //    }

        //    public void Runthread()
        //    {
        //        Thread t1 = new Thread(fun1);
        //        Thread t2 = new Thread(fun2);
        //        Thread t3 = new Thread(fun1);
        //        Thread t4 = new Thread(fun2);
        //        Thread t5 = new Thread(fun1);
        //        Thread t6 = new Thread(fun2);
        //        Thread t7 = new Thread(fun1);
        //        Thread t8 = new Thread(fun2);
        //        t1.Start();
        //        t2.Start();
        //        t3.Start();
        //        t4.Start();
        //        t5.Start();
        //        t6.Start();
        //        t7.Start();
        //        t8.Start();
        //    }

        //    //static async Task GetResponse()
        //    //{
        //    //    HttpClient client = new HttpClient();
        //    //    HttpResponseMessage response = await client.GetAsync("http://192.168.10.120:8021/Api/Examination/product?productId=TC201604081442440001");
        //    //    response.EnsureSuccessStatusCode();
        //    //    string responseBody = await response.Content.ReadAsStringAsync();
        //    //    Console.WriteLine(responseBody);
        //    //    Console.Write("heihei");
        //    //}
        //    //public void GetResponse()
        //    //{
        //    //    HttpClient client = new HttpClient(new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip });
        //    //    Task<HttpRequestMessage> taskResponse = client.GetAsync("http://192.168.10.120:8021/Api/Examination/product?productId=TC201604081442440001");

        //    //}

        //    static void fun1()
        //    {
        //        int amount = 100000;
        //        while (amount > 0)
        //        {
        //            Console.WriteLine("a");
        //            amount--;
        //        }

        //    }

        //    static void fun2()
        //    {
        //        int amount = 100000;
        //        while (amount > 0)
        //        {
        //            Console.WriteLine("b");
        //            amount--;
        //        }

        //    }
        //}

        ///// <summary>
        ///// 短信发送接受结果
        ///// </summary>
        //public class SmsResult
        //{
        //    /// <summary>
        //    /// 是否成功
        //    /// </summary>
        //    public bool isSuccess;
        //    /// <summary>
        //    /// </summary>
        //    public string remark;
        //}


    //    public class PostData
    //    {
    //        /// <summary>
    //        /// 客户端编号 区分：社保100营销， 深圳市泛亚人力资源有限公司， 泛亚人力员工服务微信号， HRPO员工提醒 ，易社保， 我薪 ，泛员网 ，社保100验证码，
    //        /// </summary>
    //        public string ClientNumber { get; set; }

    //        /// <summary>
    //        /// 发件人姓名
    //        /// </summary>
    //        public string SenderName { get; set; }

    //        /// <summary>
    //        /// 发件人ID
    //        /// </summary>
    //        public string SenderID { get; set; }

    //        /// <summary>
    //        /// 收件人姓名
    //        /// </summary>
    //        public string ReceiverName { get; set; }

    //        /// <summary>
    //        /// 收件号码
    //        /// </summary>
    //        public string ReceiverPhone { get; set; }

    //        /// <summary>
    //        /// 短信内容
    //        /// </summary>
    //        public string SMSContent { get; set; }
    //    }

    //}

}

