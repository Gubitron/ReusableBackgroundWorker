using Quartz;
using System;
using System.Threading.Tasks;

namespace BackgroundWorker;

public class Job3 : IJob
{
    public Task Execute(IJobExecutionContext context)
    {
        Console.WriteLine(DateTime.Now.ToString("[yyyy-MM-dd][HH-mm-ss-ffff]") + ": job3");
        return Task.CompletedTask;
    }
}
