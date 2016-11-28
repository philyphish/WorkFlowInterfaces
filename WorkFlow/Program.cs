namespace WorkFlow
{
    class Program
    {
        static void Main(string[] args)
        {

            var workFlowEngine = new WorkFlowEngine();
            
            //simulates user input or config file
            workFlowEngine.RegisteroWorkFlow(new StartActivity());
            workFlowEngine.RegisteroWorkFlow(new BuildActivity());
            workFlowEngine.RegisteroWorkFlow(new EndActivity());
            workFlowEngine.Run();
            
        }
    }
}
