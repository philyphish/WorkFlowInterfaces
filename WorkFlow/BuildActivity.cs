using System;

namespace WorkFlow
{

    public class BuildActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Activity is running");
        }
    }
}