using System;
using System.Threading;
using Quartz;
using Quartz.Impl;
using static Quartz.MisfireInstruction;

namespace scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
           

            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();
            

            //Job1(schedulerFactory);
            Job2(schedulerFactory);

            //schedulerstart(scheduler);
            Console.ReadKey();
        }
        public static void show()
        {
            while (1 == 1)
            {
                Console.WriteLine("111");
            }
            
        }

        public static void Job1(ISchedulerFactory sf)
        {
            IScheduler scheduler = sf.GetScheduler().GetAwaiter().GetResult();
            scheduler.Start();
            IJobDetail mysql = JobBuilder.Create<DaoJob>().Build();
            ISimpleTrigger simpleTrigger = (ISimpleTrigger)TriggerBuilder.Create().StartNow().
                WithSimpleSchedule(s => s.WithIntervalInSeconds(1).WithRepeatCount(2)).Build();
            scheduler.ScheduleJob(mysql,simpleTrigger);
            //scheduler.Shutdown();
        }

        public static void Job2(ISchedulerFactory sf)
        {
            IScheduler scheduler =  sf.GetScheduler().GetAwaiter().GetResult();
            scheduler.Start();
            IJobDetail job = JobBuilder.Create<Job>().Build();
            ITrigger cronTrigger = TriggerBuilder.Create()
                .ForJob(job)
                .WithCronSchedule(" 1/3 * * * *  ? ").StartNow().Build();
            scheduler.ScheduleJob(job,cronTrigger);
            //scheduler.Shutdown();
        }


        public static void schedulerstart(IScheduler scheduler)
        {
            //ISchedulerFactory schedulerFactory = new StdSchedulerFactory();
            //IScheduler scheduler = schedulerFactory.GetScheduler().GetAwaiter().GetResult();            

            DateTimeOffset startTime = DateTime.Now.AddSeconds(3);
            DateTimeOffset endTime = DateTime.Now.AddMinutes(2);

            //ISimpleTrigger trigger = (ISimpleTrigger)TriggerBuilder.Create().StartAt(startTime).EndAt(endTime).
            //    WithSimpleSchedule(s => s.WithIntervalInSeconds(1).WithRepeatCount(100)).Build();

            IJobDetail job = JobBuilder.Create<Job>().Build();
            ISimpleTrigger simpleTrigger = (ISimpleTrigger)TriggerBuilder.Create().StartNow().
                WithSimpleSchedule(s => s.WithIntervalInSeconds(1).WithRepeatCount(2)).Build();

            // using cronTrigger
           // IJobDetail funStack = JobBuilder.Create<Job>().Build();
            ITrigger cronTrigger = TriggerBuilder.Create()
                .ForJob(job)
                .WithCronSchedule(" 0/1 * * * *  ? ").StartNow().Build();

            IJobDetail mysql = JobBuilder.Create<DaoJob>().Build();

            scheduler.ScheduleJob(job, simpleTrigger);
            scheduler.ScheduleJob(mysql, simpleTrigger);

            //scheduler.ScheduleJob(job, cronTrigger);
           
            //scheduler.ScheduleJob(job, cronTrigger);
            scheduler.Start();
        }



    }
}
