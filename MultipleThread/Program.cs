using System;
using System.Threading;

namespace MultipleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            a.show();


            bool done = false;
            ThreadStart action = () =>
            {
                if (!done)
                {
                    done = true;
                    Console.WriteLine("Done");
                }
            };

            new Thread(action).Start();
            action();


            Console.WriteLine("Hello World!");
        }


        public void show()
        {
            Console.WriteLine(" i ma kiko!! ");
        }
    }
}
