using Quartz;
using Quartz.Impl;
using System;
using System.Threading.Tasks;

namespace schedulemission
{
    class Program
    {
        static void  Main(string[] args)
        {
            Task<IScheduler> scheduler = StdSchedulerFactory.GetDefaultScheduler();//创建调度实例

            IJobDetail job = JobBuilder.Create<HermanJob>().WithIdentity(new JobKey("job1")).Build();// initialize mission

            DateTimeOffset starttime = DateTime.Now.AddMinutes(1);
            DateTimeOffset endtime = DateTime.Now.AddMinutes(2);

            ISimpleTrigger trigger =
                (ISimpleTrigger)TriggerBuilder.Create()
                    .StartAt(starttime)
                    .EndAt(endtime)
                    .WithSimpleSchedule(x => x.WithIntervalInSeconds(1).WithRepeatCount(4)).Build();

           // scheduler.SchedulerJob

           // ITrigger trigger = TriggerBuilder.Create().StartAt(DateTime.Now.AddSeconds(5)).WithCronSchedule("1").Build();// initialize trigger

            //ISchedulerFactory scheduleFactory = new StdSchedulerFactory();
            //Task<IScheduler> scheduler = scheduleFactory.GetScheduler();

            //var jobBuilder = new JobBuilder();
            //IJobDetail job = new JobBuilder.Create<HermanJob>().Build();



            scheduler.Start();
            
        }
    }
}
