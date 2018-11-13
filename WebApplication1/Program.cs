using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Quartz;
using Quartz.Impl;
using quartzInWebApplication;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)

        {
            scheduler();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static void scheduler()
        {
            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();
            IScheduler scheduler = schedulerFactory.GetScheduler().GetAwaiter().GetResult();
          
            DateTimeOffset startTime = DateTime.Now.AddSeconds(3);
            DateTimeOffset endTime = DateTime.Now.AddMinutes(2);

            //ISimpleTrigger trigger = (ISimpleTrigger)TriggerBuilder.Create().StartAt(startTime).EndAt(endTime).
            //    WithSimpleSchedule(s => s.WithIntervalInSeconds(1).WithRepeatCount(100)).Build();

            ISimpleTrigger trigger = (ISimpleTrigger)TriggerBuilder.Create().StartAt(startTime).
                WithSimpleSchedule(s => s.WithIntervalInSeconds(1).WithRepeatCount(1)).Build();

            // using cronTrigger
            IJobDetail job1 = JobBuilder.Create<Job>().Build();
            
            ITrigger cronTrigger = TriggerBuilder.Create()
                .ForJob(job1)
                .WithCronSchedule(" 0/1 * * * * ? ").StartNow().Build();
            IJobDetail job2 = JobBuilder.Create<DaoJob>().Build();
           
            //scheduler.ScheduleJob(job1, cronTrigger);
            //scheduler.ScheduleJob(job1, trigger);
            scheduler.Start();
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
