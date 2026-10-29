using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.step_4
{

    class Arrays
    {
        public static void Main()
        {
            IntegerArray();
            StringArray();
            DoubleArray();
            CharArray();
            BooleanArray();
            UpdateArray();
            AddElement();
            DeleteElement();
            SearchArray();
            SortArray();
            CopyArray();
            PassArrayToMethod();
            ReturnArrayFromMethod();
            ParamsExample();
            ResizeArray();
            ClearArray();
        }

        static void IntegerArray()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine(string.Join(", ", numbers));
        }

        static void StringArray()
        {
            string[] names = { "Mahendra", "Madan", "Kavya" };

            Console.WriteLine(names[0]);

            names[1] = "Manvika";

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void DoubleArray()
        {
            double[] prices = { 99.50, 150.75, 200.25 };

            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            Console.WriteLine(total);
        }

        static void CharArray()
        {
            char[] letters = { 'A', 'B', 'C', 'D' };

            letters[1] = 'Z';

            Console.WriteLine(string.Join(", ", letters));
        }

        static void BooleanArray()
        {
            bool[] attendance = { true, false, true, true };

            foreach (bool present in attendance)
            {
                Console.WriteLine(present);
            }
        }

        static void UpdateArray()
        {
            int[] numbers = { 10, 20, 30 };

            numbers[1] = 100;

            Console.WriteLine(string.Join(", ", numbers));
        }

        static void AddElement()
        {
            string[] names = { "Mahendra", "Madan" };

            Array.Resize(ref names, names.Length + 1);

            names[names.Length - 1] = "Kavya";

            Console.WriteLine(string.Join(", ", names));
        }

        static void DeleteElement()
        {
            int[] numbers = { 10, 20, 30, 40 };

            int deleteIndex = 1;
            int[] updated = new int[numbers.Length - 1];

            for (int i = 0, j = 0; i < numbers.Length; i++)
            {
                if (i != deleteIndex)
                {
                    updated[j] = numbers[i];
                    j++;
                }
            }

            Console.WriteLine(string.Join(", ", updated));
        }

        static void SearchArray()
        {
            string[] names = { "Mahendra", "Madan", "Kavya" };

            Console.WriteLine(Array.IndexOf(names, "Madan"));
            Console.WriteLine(Array.IndexOf(names, "Ravi"));
        }

        static void SortArray()
        {
            double[] prices = { 250.50, 100.25, 400.75, 150.00 };

            Array.Sort(prices);

            Console.WriteLine(string.Join(", ", prices));

            Array.Reverse(prices);

            Console.WriteLine(string.Join(", ", prices));
        }

        static void CopyArray()
        {
            char[] original = { 'A', 'B', 'C' };
            char[] copy = new char[original.Length];

            Array.Copy(original, copy, original.Length);

            Console.WriteLine(string.Join(", ", copy));
        }

        static void PassArrayToMethod()
        {
            string[] names = { "Mahendra", "Madan", "Kavya" };

            DisplayNames(names);

            names[0] = "Ravi";

            DisplayNames(names);
        }

        static void DisplayNames(string[] names)
        {
            Console.WriteLine(string.Join(", ", names));
        }

        static int[] ReturnArrayFromMethod()
        {
            return new int[] { 100, 200, 300 };
        }

        static void ParamsExample()
        {
            PrintNumbers(10, 20, 30);
            PrintNumbers(5, 15);
        }

        static void PrintNumbers(params int[] numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }

        static void ResizeArray()
        {
            double[] prices = { 10.50, 20.75 };

            Array.Resize(ref prices, 4);

            prices[2] = 30.25;
            prices[3] = 40.50;

            Console.WriteLine(string.Join(", ", prices));
        }

        static void ClearArray()
        {
            int[] numbers = { 10, 20, 30, 40 };

            Array.Clear(numbers, 1, 2);

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
