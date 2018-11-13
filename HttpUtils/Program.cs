using System;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = new string("duoduo");
            

            //string ssss = HttpUtils.Get("https://localhost:44345/Reservation/Alert");
            //Console.WriteLine("-------" + ssss);
           
            string name = HttpUtils.Post("https://localhost:44340/MitzuNomo/Say", " zhangsan");
            Console.WriteLine(name);

            PairDto p = new PairDto();
            p.OrderId = 1410101029;
            p.PhoneNumber = "274903423";
            string Process = HttpUtils.Post("https://localhost:44340/MitzuNomo/Process", p);
            Console.WriteLine(Process);
        }
    }
}
