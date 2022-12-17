using System;
using System.Threading;

namespace BackgroundWorker;

internal class Program
{
    static void Main(string[] args)
    {
        int interval = 100;
        Console.WriteLine("Create worker");
        var job1 = new BackgroundWorker("Job1", "Trigger1", interval, typeof(Job1));
        var job2 = new BackgroundWorker("Job2", "Trigger2", interval, typeof(Job2));
        var job3 = new BackgroundWorker("Job3", "Trigger3", interval, typeof(Job3));

        job1.Start();
        job2.Start();
        job3.Start();
        Console.WriteLine("Workers started");

        //Thread.Sleep(interval*10);
        Console.ReadLine();

        job1.Stop();
        job2.Stop();
        job3.Stop();
        Console.WriteLine("Workers stopped");

        Console.ReadLine();
    }
}
