using Quartz;
using Quartz.Impl;
using ScheduleTest.jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule
{
    public class QuartzStartup
    {
        private IScheduler _scheduler; // after Start, and until shutdown completes, references the scheduler object

        public void Start()
        {
            Console.WriteLine("Schedule started");

            if (_scheduler != null)
            {
                throw new InvalidOperationException("Already started.");
            }

            var schedulerFactory = new StdSchedulerFactory();
            _scheduler = schedulerFactory.GetScheduler().Result;
            _scheduler.Start().Wait();


            DateTimeOffset startTime = DateTime.Now.AddSeconds(1);
            ISimpleTrigger startNow = (ISimpleTrigger)TriggerBuilder.Create().StartNow().WithSimpleSchedule
                (s => s.WithIntervalInSeconds(1).WithRepeatCount(0)).Build();
            ISimpleTrigger startNow1 = (ISimpleTrigger)TriggerBuilder.Create().StartNow().WithSimpleSchedule
                (s => s.WithIntervalInSeconds(1).WithRepeatCount(10)).Build();

            ISimpleTrigger TestTrigger = (ISimpleTrigger)TriggerBuilder.Create().StartNow().WithSimpleSchedule
                (s => s.WithIntervalInSeconds(1).WithRepeatCount(2)).Build();

            var TestJob1 = JobBuilder.Create<TestJob>().Build();
            
            _scheduler.ScheduleJob(TestJob1, startNow1).Wait();
        }

    }
}
