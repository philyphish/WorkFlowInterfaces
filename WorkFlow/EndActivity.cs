using System;

namespace WorkFlow
{

    public class EndActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("End Activity");
        }
    }
}