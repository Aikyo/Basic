using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Connection;

namespace quartzInWebApplication
{
    public class DaoJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            MysqlHelper.Connect();
            throw new NotImplementedException();
        }
    }
}
