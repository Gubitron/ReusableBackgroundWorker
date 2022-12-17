using Quartz;
using System;
using System.Threading.Tasks;

namespace BackgroundWorker;

public class Job2 : IJob
{
    public Task Execute(IJobExecutionContext context)
    {
        Console.WriteLine(DateTime.Now.ToString("[yyyy-MM-dd][HH-mm-ss-ffff]") + ": job2");
        return Task.CompletedTask;
    }
}
