namespace BackgroundWorker;

public interface IBackgroundWorker
{
    public string JobName { get; }
    public string TriggerName { get; }
    public int IntervalInMilliseconds { get; }

    void Start();
    void Stop();
}
