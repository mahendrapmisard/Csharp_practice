using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.step_4
{
    class Hashset
    {
        public static void Main()
        {
            CreateHashSet();
            RemoveDuplicates();
            ReadHashSet();
            AddElement();
            UpdateElement();
            DeleteElement();
            SearchHashSet();
            LoopHashSet();
            CountHashSet();
            UnionExample();
            IntersectionExample();
            DifferenceExample();
            SubsetExample();
            CopyHashSet();
            PassHashSetToMethod();
            ReturnHashSetFromMethod();
            ConvertToArray();
            ClearHashSet();
        }

        static void CreateHashSet()
        {
            HashSet<int> numbers = new HashSet<int>()
        {
            10, 20, 30, 40
        };

            Console.WriteLine(string.Join(", ", numbers));
        }

        static void RemoveDuplicates()
        {
            HashSet<int> numbers = new HashSet<int>()
        {
            10, 20, 10, 30, 20, 40
        };

            Console.WriteLine(string.Join(", ", numbers));
        }

        static void ReadHashSet()
        {
            HashSet<string> names = new HashSet<string>()
        {
            "Mahendra", "Madan", "Kavya"
        };

            Console.WriteLine(names.Contains("Madan"));
        }

        static void AddElement()
        {
            HashSet<string> names = new HashSet<string>();

            names.Add("Mahendra");
            names.Add("Madan");
            names.Add("Kavya");
            names.Add("Mahendra");

            Console.WriteLine(string.Join(", ", names));
        }

        static void UpdateElement()
        {
            HashSet<int> numbers = new HashSet<int>()
        {
            10, 20, 30
        };

            numbers.Remove(20);
            numbers.Add(25);

            Console.WriteLine(string.Join(", ", numbers));
        }

        static void DeleteElement()
        {
            HashSet<int> numbers = new HashSet<int>()
        {
            10, 20, 30, 40
        };

            numbers.Remove(30);

            Console.WriteLine(string.Join(", ", numbers));
        }

        static void SearchHashSet()
        {
            HashSet<string> names = new HashSet<string>()
        {
            "Mahendra", "Madan", "Kavya"
        };

            Console.WriteLine(names.Contains("Madan"));
            Console.WriteLine(names.Contains("Ravi"));
        }

        static void LoopHashSet()
        {
            HashSet<string> names = new HashSet<string>()
        {
            "Mahendra", "Madan", "Kavya"
        };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void CountHashSet()
        {
            HashSet<double> prices = new HashSet<double>()
        {
            99.50, 150.75, 200.25
        };

            Console.WriteLine(prices.Count);
        }

        static void UnionExample()
        {
            HashSet<int> first = new HashSet<int>() { 10, 20, 30 };
            HashSet<int> second = new HashSet<int>() { 30, 40, 50 };

            first.UnionWith(second);

            Console.WriteLine(string.Join(", ", first));
        }

        static void IntersectionExample()
        {
            HashSet<int> first = new HashSet<int>() { 10, 20, 30 };
            HashSet<int> second = new HashSet<int>() { 20, 30, 40 };

            first.IntersectWith(second);

            Console.WriteLine(string.Join(", ", first));
        }

        static void DifferenceExample()
        {
            HashSet<int> first = new HashSet<int>() { 10, 20, 30 };
            HashSet<int> second = new HashSet<int>() { 20, 40 };

            first.ExceptWith(second);

            Console.WriteLine(string.Join(", ", first));
        }

        static void SubsetExample()
        {
            HashSet<int> first = new HashSet<int>() { 10, 20 };
            HashSet<int> second = new HashSet<int>() { 10, 20, 30, 40 };

            Console.WriteLine(first.IsSubsetOf(second));
            Console.WriteLine(second.IsSubsetOf(first));
        }

        static void CopyHashSet()
        {
            HashSet<string> original = new HashSet<string>()
        {
            "Java", "CSharp", "Angular"
        };

            HashSet<string> copy = new HashSet<string>(original);

            Console.WriteLine(string.Join(", ", copy));
        }

        static void PassHashSetToMethod()
        {
            HashSet<int> numbers = new HashSet<int>()
        {
            10, 20, 30
        };

            DisplayNumbers(numbers);
        }

        static void DisplayNumbers(HashSet<int> numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }

        static HashSet<string> ReturnHashSetFromMethod()
        {
            return new HashSet<string>()
        {
            "Java", "CSharp", "Angular"
        };
        }

        static void ConvertToArray()
        {
            HashSet<int> numbers = new HashSet<int>()
        {
            10, 20, 30
        };

            int[] result = new int[numbers.Count];
            numbers.CopyTo(result);

            Console.WriteLine(string.Join(", ", result));
        }

        static void ClearHashSet()
        {
            HashSet<int> numbers = new HashSet<int>()
        {
            10, 20, 30
        };

            numbers.Clear();

            Console.WriteLine(numbers.Count);
        }
    }
}
}
