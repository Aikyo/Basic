using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace schedulemission
{
    class HermanJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine(DateTime.Now.ToString() + "sleep for a while herman!! ");
            return null;
        }

        public void Print(IJobExecutionContext context)
        {
            Console.WriteLine(DateTime.Now.ToString() + "sleep for a while herman!! ");
        }
    }
}
