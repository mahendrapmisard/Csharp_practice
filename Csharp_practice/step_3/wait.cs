using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.step_3
{
    class Wait
    {
        static void Main()
        {
         Task.Run(() =>
            {
                Console.WriteLine("Task started");
                Thread.Sleep(3000);
                Console.WriteLine("Task completed");
            });

            Console.WriteLine("Before Wait");

            //task.Wait();

            Console.WriteLine("After Wait");
            Task.Run(() =>
            {
                Console.WriteLine("Task started");
                Thread.Sleep(7000);
                Console.WriteLine("Task completed");
            });
            Console.ReadLine();
        }
    }
}
