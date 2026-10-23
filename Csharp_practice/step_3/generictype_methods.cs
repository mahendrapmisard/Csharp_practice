using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.step_3
{

    class Program
    {
        static T GetValue<T>(T value)
        {
            return value;
        }

        static int Add(int a, int b = 10)
        {
            return a + b;
        }

        static void Main()
        {
            Console.WriteLine(GetValue<int>(100));
            Console.WriteLine(GetValue<string>("Hello"));
            Console.WriteLine(GetValue<double>(10.5));

            Console.WriteLine(Add(5));
            Console.WriteLine(Add(5, 20));
        }
    }
}
