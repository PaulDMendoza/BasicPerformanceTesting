using System;
using System.Threading;

namespace Tester
{
    public class Loop100Times : ITester
    {
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Loop " + i);
                Thread.Sleep(1000);
            }
        }
        
        public string Description { get { return "Loop 100 times and sleep 1 second for each loop."; } }
    }
}