using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Connection;

namespace scheduler
{
    class DaoJob : IJob
    {
       
        public Task Execute(IJobExecutionContext context)
        {
            MysqlHelper.Connect();
            throw new NotImplementedException();
        }
    }
}
