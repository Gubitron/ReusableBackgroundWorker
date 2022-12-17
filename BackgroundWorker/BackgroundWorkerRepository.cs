using System.Collections.Generic;
using System.Linq;

namespace BackgroundWorker;

public class BackgroundWorkerRepository : IBackgroundWorkerRepository
{
    private List<IBackgroundWorker> _backgroundWorkers;

    public BackgroundWorkerRepository()
    {
        _backgroundWorkers = new List<IBackgroundWorker>();
    }

    public void Add(IBackgroundWorker worker)
    {
        _backgroundWorkers.Add(worker);
    }

    public void Delete(IBackgroundWorker worker)
    {
        _backgroundWorkers.Remove(worker);
    }

    public IEnumerable<IBackgroundWorker> GetAll()
    {
        return _backgroundWorkers;
    }

    public IEnumerable<IBackgroundWorker> GetByJobName(string jobName)
    {
        return _backgroundWorkers.Where(x => x.JobName == jobName);
    }

    public IEnumerable<IBackgroundWorker> GetByTriggerName(string triggerName)
    {
        return _backgroundWorkers.Where(x => x.TriggerName == triggerName);
    }
}
