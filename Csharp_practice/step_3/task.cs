using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.task
{


    class Tasks
    {
        public static void Main()
        {
            WaitAnyDemo();
            WaitAllDemo();
            WaitDemo();
            ResultDemo();
            WhenAllDemo().GetAwaiter().GetResult();
            WhenAnyDemo().GetAwaiter().GetResult();
            DelayDemo().GetAwaiter().GetResult();
            CompletedTaskDemo();
            FromResultDemo();
            StatusDemo();
            WaitAsyncDemo().GetAwaiter().GetResult();

            Console.WriteLine("All examples completed");
        }

        static void WaitAnyDemo()
        {
            Console.WriteLine("\n--- Task.WaitAny ---");

            Task t1 = Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Task 1 finished");
            });

            Task t2 = Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Task 2 finished");
            });

            int index = Task.WaitAny(t1, t2);

            Console.WriteLine("First completed task index: " + index);

            Task.WaitAll(t1, t2);
        }

        static void WaitAllDemo()
        {
            Console.WriteLine("\n--- Task.WaitAll ---");

            Task t1 = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("First task finished");
            });

            Task t2 = Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Second task finished");
            });

            Task.WaitAll(t1, t2);

            Console.WriteLine("Both tasks finished");
        }

        static void WaitDemo()
        {
            Console.WriteLine("\n--- Task.Wait ---");

            Task t = Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Background work finished");
            });

            Console.WriteLine("Main continues");
            t.Wait();

            Console.WriteLine("Main continues after Wait");
        }

        static void ResultDemo()
        {
            Console.WriteLine("\n--- Task.Result ---");

            Task<int> intTask = Task.Run(() => 100);
            Task<string> stringTask = Task.Run(() => "Hello");
            Task<bool> boolTask = Task.Run(() => true);
            Task<double> doubleTask = Task.Run(() => 10.5);

            Console.WriteLine(intTask.Result);
            Console.WriteLine(stringTask.Result);
            Console.WriteLine(boolTask.Result);
            Console.WriteLine(doubleTask.Result);
        }

        static async Task WhenAllDemo()
        {
            Console.WriteLine("\n--- Task.WhenAll ---");

            Task<int> t1 = Task.Run(async () =>
            {
                await Task.Delay(1000);
                return 10;
            });

            Task<int> t2 = Task.Run(async () =>
            {
                await Task.Delay(2000);
                return 20;
            });

            int[] results = await Task.WhenAll(t1, t2);

            Console.WriteLine(results[0]);
            Console.WriteLine(results[1]);
            Console.WriteLine("All results received");
        }

        static async Task WhenAnyDemo()
        {
            Console.WriteLine("\n--- Task.WhenAny ---");

            Task<int> t1 = Task.Run(async () =>
            {
                await Task.Delay(1000);
                return 30;
            });

            Task<int> t2 = Task.Run(async () =>
            {
                await Task.Delay(3000);
                return 40;
            });

            Task<int> first = await Task.WhenAny(t1, t2);

            Console.WriteLine("First result: " + await first);

            await Task.WhenAll(t1, t2);
            Console.WriteLine("Remaining task also finished");
        }

        static async Task DelayDemo()
        {
            Console.WriteLine("\n--- Task.Delay ---");

            Console.WriteLine("Waiting");
            await Task.Delay(1000);
            Console.WriteLine("Delay finished");
        }

        static void CompletedTaskDemo()
        {
            Console.WriteLine("\n--- Task.CompletedTask ---");

            Task t = Task.CompletedTask;

            t.Wait();

            Console.WriteLine("Task was already completed");
        }

        static void FromResultDemo()
        {
            Console.WriteLine("\n--- Task.FromResult ---");

            Task<int> t = Task.FromResult(500);

            Console.WriteLine(t.Result);
        }

        static void StatusDemo()
        {
            Console.WriteLine("\n--- Task Status ---");

            Task t = Task.Run(() => Console.WriteLine("Working"));

            t.Wait();

            Console.WriteLine("IsCompleted: " + t.IsCompleted);
            Console.WriteLine("Status: " + t.Status);
        }

        static async Task WaitAsyncDemo()
        {
            Console.WriteLine("\n--- Task.WaitAsync ---");

            Task t = Task.Run(async () =>
            {
                await Task.Delay(1000);
                Console.WriteLine("Work finished");
            });

            await t.WaitAsync(TimeSpan.FromSeconds(5));

            Console.WriteLine("WaitAsync finished");
        }
    }


}
