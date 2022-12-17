using Quartz;
using System;
using System.Threading.Tasks;

namespace BackgroundWorker;

public class Job1 : IJob
{
    public Task Execute(IJobExecutionContext context)
    {
        Console.WriteLine(DateTime.Now.ToString("[yyyy-MM-dd][HH-mm-ss-ffff]") + ": job1");
        return Task.CompletedTask;
    }
}
