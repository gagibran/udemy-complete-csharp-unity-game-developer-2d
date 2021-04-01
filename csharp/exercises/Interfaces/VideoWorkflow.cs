using System;
using System.Collections.Generic;

namespace Interfaces
{
    public class VideoWorkflow : IWorkflow
    {
        private readonly List<IActivity> _activities;
        public VideoWorkflow()
        {
            _activities = new List<IActivity>();
        }
        public void AddActivity(params IActivity[] activities)
        {

            foreach (var activity in activities)
            {
                if (activity == null)
                {
                    throw new InvalidOperationException("An activity cannot be null.");
                }
                _activities.Add(activity);
            }
        }

        public void RemoveActivity(IActivity activity)
        {
            if (!_activities.Contains(activity))
            {
                throw new InvalidOperationException("This activity is not present in this workflow.");
            }
            _activities.Remove(activity);
        }

        // We're returning IEnummerable here so that the WorkflowEngine class cannot modified the list with the activities.
        // IEnummerable doesn't have methods like Add() or Remove(), so the list doesn't get messed up.
        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}
