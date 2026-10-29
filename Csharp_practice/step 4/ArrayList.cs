using System;
using System.Collections;


namespace Csharp_practice.step_4
{
    class ArrayLists
    {
        public static void Main()
        {
            CreateArrayList();
            DifferentDataTypes();
            ReadArrayList();
            UpdateElement();
            AddElement();
            InsertElement();
            DeleteElement();
            SearchArrayList();
            SortArrayList();
            ReverseArrayList();
            CopyArrayList();
            PassArrayListToMethod();
            ReturnArrayListFromMethod();
            CountAndCapacity();
            RemoveAllElements();
        }

        static void CreateArrayList()
        {
            ArrayList numbers = new ArrayList() { 10, 20, 30, 40 };

            Console.WriteLine(string.Join(", ", numbers.ToArray()));
        }

        static void DifferentDataTypes()
        {
            ArrayList values = new ArrayList();

            values.Add(100);
            values.Add("Mahendra");
            values.Add(25.5);
            values.Add('A');
            values.Add(true);

            foreach (object value in values)
            {
                Console.WriteLine(value);
            }
        }

        static void ReadArrayList()
        {
            ArrayList names = new ArrayList() { "Mahendra", "Madan", "Kavya" };

            Console.WriteLine(names[0]);

            foreach (object name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void UpdateElement()
        {
            ArrayList numbers = new ArrayList() { 10, 20, 30 };

            numbers[1] = 200;

            Console.WriteLine(string.Join(", ", numbers.ToArray()));
        }

        static void AddElement()
        {
            ArrayList names = new ArrayList() { "Mahendra", "Madan" };

            names.Add("Kavya");

            Console.WriteLine(string.Join(", ", names.ToArray()));
        }

        static void InsertElement()
        {
            ArrayList numbers = new ArrayList() { 10, 30, 40 };

            numbers.Insert(1, 20);

            Console.WriteLine(string.Join(", ", numbers.ToArray()));
        }

        static void DeleteElement()
        {
            ArrayList numbers = new ArrayList() { 10, 20, 30, 40 };

            numbers.Remove(30);

            Console.WriteLine(string.Join(", ", numbers.ToArray()));

            numbers.RemoveAt(0);

            Console.WriteLine(string.Join(", ", numbers.ToArray()));
        }

        static void SearchArrayList()
        {
            ArrayList names = new ArrayList() { "Mahendra", "Madan", "Kavya" };

            Console.WriteLine(names.Contains("Madan"));
            Console.WriteLine(names.IndexOf("Kavya"));
            Console.WriteLine(names.IndexOf("Ravi"));
        }

        static void SortArrayList()
        {
            ArrayList numbers = new ArrayList() { 40, 10, 30, 20 };

            numbers.Sort();

            Console.WriteLine(string.Join(", ", numbers.ToArray()));
        }

        static void ReverseArrayList()
        {
            ArrayList names = new ArrayList() { "Mahendra", "Madan", "Kavya" };

            names.Reverse();

            Console.WriteLine(string.Join(", ", names.ToArray()));
        }

        static void CopyArrayList()
        {
            ArrayList original = new ArrayList() { 10, 20, 30 };

            ArrayList copy = (ArrayList)original.Clone();

            Console.WriteLine(string.Join(", ", copy.ToArray()));
        }

        static void PassArrayListToMethod()
        {
            ArrayList names = new ArrayList() { "Mahendra", "Madan" };

            DisplayArrayList(names);

            names.Add("Kavya");

            DisplayArrayList(names);
        }

        static void DisplayArrayList(ArrayList values)
        {
            Console.WriteLine(string.Join(", ", values.ToArray()));
        }

        static ArrayList ReturnArrayListFromMethod()
        {
            return new ArrayList() { "Java", "C#", "Angular" };
        }

        static void CountAndCapacity()
        {
            ArrayList numbers = new ArrayList() { 10, 20, 30 };

            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Capacity);
        }

        static void RemoveAllElements()
        {
            ArrayList values = new ArrayList() { 10, "Mahendra", true };

            values.Clear();

            Console.WriteLine(values.Count);
        }
    }
}
