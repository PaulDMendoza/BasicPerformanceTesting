using System;

namespace Tester
{
    public class MeasureCPU : ITester
    {
        public void Run()
        {
            for (int i = 0; i < 10000; i++)
            {
                var someValue = Math.Cos(Math.Sqrt(Math.Pow(i, 4)));
                var anotherValue = someValue*1000;

            }
        }

        public string Description { get { return "Loop 10000 times and perform a math function"; } }
    }
}