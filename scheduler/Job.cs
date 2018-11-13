using Quartz;
using System;
using System.Threading.Tasks;


namespace scheduler
{
    class Job : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {


            // string result = HttpClientHelper.httpClient("http://192.168.10.144:8018");
            // Console.WriteLine("disgusting" + result);
            Console.WriteLine(" i won't be happay anymore "  +DateTime.Now);
            return Task.FromResult<object>(null);
        }

        public void print()
        {          
            Console.WriteLine("hello world!!");
        }
    }
}
