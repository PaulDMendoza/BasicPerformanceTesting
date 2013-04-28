using System;
using System.Threading;

namespace Tester
{
    public class Loop50Times : ITester
    {
        public void Run()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Loop " + i);
                Thread.Sleep(1000);
            }
        }
        
        public string Description { get { return "Loop 50 times and sleep 1 second for each loop."; } }
    }
}