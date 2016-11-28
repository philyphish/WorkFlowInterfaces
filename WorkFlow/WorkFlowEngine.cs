using System.Collections.Generic;

namespace WorkFlow
{
    public class WorkFlowEngine
    {
        private readonly IList<IActivity> _workFlow;

        public WorkFlowEngine()
        {
            _workFlow = new List<IActivity>();
        }
        public void RegisteroWorkFlow(IActivity activity)
        {
            _workFlow.Add(activity);
        }
        public void Run()
        {
            foreach (var activity in _workFlow)
            {
                System.Console.WriteLine(activity);
            }
        }
    }
}