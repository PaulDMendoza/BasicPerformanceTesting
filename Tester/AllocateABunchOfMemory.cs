using System;
using System.Collections.Generic;

namespace Tester
{
    public class AllocateABunchOfMemory : ITester
    {
        private List<List<int>> arrayOfArrays = new List<List<int>>();  
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                var largeArray = new List<int>(1000000);
                arrayOfArrays.Add(largeArray);

                Console.WriteLine("Large Arrays Created: " + (i + 1));
            }
        }

        public string Description { get { return "Loop 100 times and allocate a bunch of memory"; } }
    }
}