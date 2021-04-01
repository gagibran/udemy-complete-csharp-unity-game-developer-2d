using System.Collections.Generic;

namespace Interfaces
{
    public interface IWorkflow
    {
        void AddActivity(params IActivity[] activities);
        void RemoveActivity(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}
