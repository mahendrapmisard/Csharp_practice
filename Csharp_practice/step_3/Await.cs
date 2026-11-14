using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.step_3
{
    class Program
    {
        public static async Task Main()
        {
            Console.WriteLine("Start");

            await GetData();

            Console.WriteLine("End");
        }

        public static async Task GetData()
        {
            Console.WriteLine("Fetching data...");

            await Task.Delay(3000);

            Console.WriteLine("Data received");
        }
    }
}
