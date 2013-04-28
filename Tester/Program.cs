using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic .NET tester");

            var iTesterType = typeof (ITester);
            var iTestersTypes = Assembly.GetExecutingAssembly().GetTypes().Where(p => iTesterType.IsAssignableFrom(p));

            var iTesters = iTestersTypes.Where(t => !t.IsInterface).Select(s =>
                {
                    return (ITester) s.GetConstructor(new Type[] {}).Invoke(new object[] {});
                });


            while (true)
            {
                foreach (var iTester in iTesters)
                {
                    Console.WriteLine(iTester.GetType().Name + " - " + iTester.Description);
                }

                Console.Write("Type in the name of an option and hit ENTER:");
                var option = Console.ReadLine();

                var matchingITester = iTesters.FirstOrDefault(t => string.Compare(t.GetType().Name, option.Trim(), true) == 0);
                if (matchingITester == null)
                {
                    Console.WriteLine("Invalid option picked. Be sure to just type the name. ");
                }
                else
                {
                    var stw = new Stopwatch();
                    stw.Start();
                    Console.WriteLine("Starting at " + DateTime.Now.ToLongTimeString());
                    try
                    {
                        matchingITester.Run();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex);
                    }
                    stw.Stop();
                    Console.WriteLine("Finished at " + DateTime.Now.ToLongTimeString() + " with elapsed time of " + stw.Elapsed.TotalSeconds + " seconds.");
                }
            }
        }
    }
}
