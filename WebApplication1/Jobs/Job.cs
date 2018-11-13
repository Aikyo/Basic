using Quartz;
using System;
using System.Threading.Tasks;


namespace WebApplication1
{
    class Job : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {                      
           // string result = HttpClientHelper.httpClient("http://192.168.10.144:8018");
           // Console.WriteLine("disgusting" + result);
            throw new NotImplementedException();
        }
    }
}
