using Quartz;
using Quartz.Impl;
using System;
using System.Reflection;

namespace BackgroundWorker;

public class BackgroundWorker : IBackgroundWorker
{
    private readonly IScheduler _scheduler;
    public string JobName { get; private set; }
    public string TriggerName { get; private set; }
    public int IntervalInMilliseconds { get; private set; }

    public BackgroundWorker(string jobName, 
                            string triggerName, 
                            int intervalInMilliseconds, 
                            Type type)
    {
        ISchedulerFactory scheduleFactory = new StdSchedulerFactory();
        _scheduler = scheduleFactory.GetScheduler().Result;

        JobName = jobName;
        TriggerName = triggerName;
        IntervalInMilliseconds = intervalInMilliseconds;

        IJobDetail job = JobBuilder.Create(type)
            .WithIdentity(jobName)
            .Build();

        ITrigger trigger = TriggerBuilder.Create()
            .WithIdentity(triggerName)
            .StartNow()
            .WithSimpleSchedule(x => x
                                .WithInterval(TimeSpan.FromMilliseconds(intervalInMilliseconds))
                                .RepeatForever())
            .Build();

        _scheduler.ScheduleJob(job, trigger);
    }

    // TODO:
    // Need to figure out await functionality for tasks
    // Overload for starting at specific time
    // Overload for executing a finite number of tasks
    // Overload for executing a task until a certain result is met..?
    // Somehow apply Guid, instead of specifying job names..? Would that be harder to read?
    // Want to keep interval in ms throughout all for consistency. Calling code can use value objects to do the conversion?
    // Do we need scope definitions available through this class?

    public void Start()
    {
        _scheduler.Start();
    }

    public void Stop()
    {
        _scheduler.Shutdown(true);
    }
}
