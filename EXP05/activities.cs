/*
Activities : 
1. run program synchronously and measure time. : it will runs each task one after another with given timestamp
2. convert to asynchronous and measure time. : it will run tasks asynchronously means non sequencially. means runs random tasks one by one.
3. replace thread.sleep() with task.delay() observe behaviour. : Behaviour that I  Observed after replacing await Task.Delay(1000);
With Thread.Sleep() : 
it Blocks thread 
Tasks run one by one
Total time ≈ 5 seconds

With Task.Delay() : 
Non-blocking 
Tasks run concurrently
Total time ≈ 1 second
Output order may change randomly

4. create method and returning task.
*/

using System;
using System.Threading.Tasks;

namespace Exp05
{
    internal class Program
    {
        // Methods returning Task
        public static async Task Task1()
        {
            Console.WriteLine("Task1 Starting");
            await Task.Delay(1000);
            Console.WriteLine("Task1 Ending");
        }

        public static async Task Task2()
        {
            Console.WriteLine("Task2 Starting");
            await Task.Delay(1000);
            Console.WriteLine("Task2 Ending");
        }

        public static async Task Task3()
        {
            Console.WriteLine("Task3 Starting");
            await Task.Delay(1000);
            Console.WriteLine("Task3 Ending");
        }

        // OLD compiler requires void Main
        public static void Main(string[] args)
        {
            Task t1 = Task1();
            Task t2 = Task2();
            Task t3 = Task3();

            // Wait for tasks (since async Main not supported)
            Task.WaitAll(t1, t2, t3);

            Console.WriteLine("All Tasks Completed");
        }
    }
}