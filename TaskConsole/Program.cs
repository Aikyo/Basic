using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //action 
            Action<string> print1 = (string x) => Console.WriteLine(x);
            print1.Invoke("how you do?");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Main Thread : " + Thread.CurrentThread.ManagedThreadId);

            //
            Thread thread1 = new Thread(show);
            thread1.Start();

            //task use thread pool
            Task task1 = new Task(() => {
                Console.WriteLine("Constructor task1 :" + Thread.CurrentThread.ManagedThreadId);
            });
            task1.Start();

            Task task2 = Task.Factory.StartNew(() => {
                Console.WriteLine("Factory task2 : " + Thread.CurrentThread.ManagedThreadId);
            });

            
            //Console.ReadKey();

            ///
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            var task = Task.Factory.StartNew(() =>
            {
                for (var i = 0; i < 1000; i++)
                {
                    Console.WriteLine(" I wont be Happy anymore ! ");
                    System.Threading.Thread.Sleep(1000);
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Abort mission success!");
                        return;
                    }
                }
            }, token);
            token.Register(() =>
            {
                Console.WriteLine("Canceled");
            });
            Console.WriteLine("Press enter to cancel task...");
            Console.ReadKey();
            tokenSource.Cancel();
            Console.ReadKey();//这句忘了加，程序退出了，看不到“Abort mission success!“这个提示


        }

        public static void show()
        {
            Console.WriteLine("New thread1 :  " + Thread.CurrentThread.ManagedThreadId );
        }
    }
}
