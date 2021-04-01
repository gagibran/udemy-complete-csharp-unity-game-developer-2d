using System;
using System.Collections.Generic;

namespace Interfaces
{
    public class WorkflowEngine
    {
        private readonly IWorkflow _workflow;

        public WorkflowEngine(IWorkflow workflow)
        {
            _workflow = workflow;
        }

        public void Run()
        {
            var activities = _workflow.GetActivities();
            foreach (var activity in activities)
            {
                activity.Execute();
                Console.WriteLine();
            }
        }

    }
}
