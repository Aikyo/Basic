using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using Newtonsoft.Json;
using System.IO;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = new string("duoduo");
            HttpUtils.HttpClientHelper.
            string ss = HttpUtils.Post("https://localhost:44340/MitzuNomo/Say", s);
            Console.WriteLine(ss);
            
        }

        private static void show(string s)
        {
            Console.WriteLine(s + "al");
        }
    }
}
