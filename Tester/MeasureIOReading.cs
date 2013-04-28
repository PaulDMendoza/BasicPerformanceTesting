using System.IO;

namespace Tester
{
    public class MeasureIOReading : ITester
    {
        public void Run()
        {
            for (int i = 0; i < 10000; i++)
            {
                var files = Directory.GetFiles("C:\\");
            }
        }

        public string Description { get { return "Loop 10000 times and do a directory listing (Doesn't print since printing is slower than disk)"; } }
    }
}