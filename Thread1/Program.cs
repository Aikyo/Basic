using System;
using System.Threading;

namespace Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(go);
            t.Start();
            t.Join();//主线程等待当前线程执行完
            Console.WriteLine("threading  is end!!");
            Console.ReadKey();
        }
        public static void go()
        {
            int i = 50;
            while (i > 0)
            {
                Console.WriteLine(Thread.CurrentThread.Name + Thread.GetCurrentProcessorId()+ "1");
                i--;
            }
            
        }
    }
}
