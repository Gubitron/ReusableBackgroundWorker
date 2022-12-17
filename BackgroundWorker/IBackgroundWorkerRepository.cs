using System.Collections.Generic;

namespace BackgroundWorker;

public interface IBackgroundWorkerRepository
{
    void Add(IBackgroundWorker worker);
    void Delete(IBackgroundWorker worker);
    IEnumerable<IBackgroundWorker> GetAll();
    IEnumerable<IBackgroundWorker> GetByJobName(string jobName);
    IEnumerable<IBackgroundWorker> GetByTriggerName(string triggerName);
}
