using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.named

{
    class Program
    {
        static void Display(string name, int age, string city)
        {
            Console.WriteLine($"{name}, {age}, {city}");
        }

        static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach (int number in numbers)
                total += number;

            return total;
        }

        static void Main()
        {
            Display(age: 25, city: "Hyderabad", name: "Mahendra");

            Console.WriteLine(Sum(10, 20));
            Console.WriteLine(Sum(10, 20, 30, 40));
        }
    }
}
