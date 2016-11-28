using System;

namespace WorkFlow
{
    public class StartActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Start Activity");
        }
    }
}