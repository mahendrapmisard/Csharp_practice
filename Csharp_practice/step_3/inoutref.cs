using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.InOutRef
{
    class Program
    {
        static void Modify(ref int value)
        {
            value += 10;
        }

        static void GetData(out int value)
        {
            value = 100;
        }

        static void Display(in int value)
        {
            Console.WriteLine(value);
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void Main()
        {
            int number = 5;
            Modify(ref number);
            Console.WriteLine(number);

            GetData(out int result);
            Console.WriteLine(result);

            Display(in result);

            ShowMessage(message: "Hello C#");
        }
    }
}
