using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.step_4
{
     class Dictionarys
    {
        public static void Main()
        {
            CreateDictionary();
            ReadDictionary();
            UpdateValue();
            AddElement();
            RemoveElement();
            SearchDictionary();
            LoopDictionary();
            GetKeysAndValues();
            TryGetValueExample();
            CountDictionary();
            CopyDictionary();
            PassDictionaryToMethod();
            ReturnDictionaryFromMethod();
            DifferentDataTypes();
            ClearDictionary();
        }

        static void CreateDictionary()
        {
            Dictionary<int, string> students = new Dictionary<int, string>()
        {
            { 101, "Mahendra" },
            { 102, "Madan" },
            { 103, "Kavya" }
        };

            Console.WriteLine(students[101]);
        }

        static void ReadDictionary()
        {
            Dictionary<string, int> marks = new Dictionary<string, int>()
        {
            { "Java", 85 },
            { "CSharp", 90 },
            { "Angular", 80 }
        };

            Console.WriteLine(marks["CSharp"]);
        }

        static void UpdateValue()
        {
            Dictionary<int, string> students = new Dictionary<int, string>()
        {
            { 101, "Mahendra" },
            { 102, "Madan" }
        };

            students[101] = "Ravi";

            Console.WriteLine(students[101]);
        }

        static void AddElement()
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(101, "Mahendra");
            students.Add(102, "Madan");

            students[103] = "Kavya";

            Console.WriteLine(students.Count);
        }

        static void RemoveElement()
        {
            Dictionary<int, string> students = new Dictionary<int, string>()
        {
            { 101, "Mahendra" },
            { 102, "Madan" },
            { 103, "Kavya" }
        };

            students.Remove(102);

            Console.WriteLine(students.Count);
        }

        static void SearchDictionary()
        {
            Dictionary<int, string> students = new Dictionary<int, string>()
        {
            { 101, "Mahendra" },
            { 102, "Madan" }
        };

            Console.WriteLine(students.ContainsKey(101));
            Console.WriteLine(students.ContainsKey(105));
            Console.WriteLine(students.ContainsValue("Madan"));
        }

        static void LoopDictionary()
        {
            Dictionary<int, string> students = new Dictionary<int, string>()
        {
            { 101, "Mahendra" },
            { 102, "Madan" },
            { 103, "Kavya" }
        };

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " " + student.Value);
            }
        }

        static void GetKeysAndValues()
        {
            Dictionary<int, string> students = new Dictionary<int, string>()
        {
            { 101, "Mahendra" },
            { 102, "Madan" }
        };

            foreach (int id in students.Keys)
            {
                Console.WriteLine(id);
            }

            foreach (string name in students.Values)
            {
                Console.WriteLine(name);
            }
        }

        static void TryGetValueExample()
        {
            Dictionary<int, string> students = new Dictionary<int, string>()
        {
            { 101, "Mahendra" },
            { 102, "Madan" }
        };

            if (students.TryGetValue(101, out string name))
            {
                Console.WriteLine(name);
            }

            if (!students.TryGetValue(105, out string missingName))
            {
                Console.WriteLine("Key not found");
            }
        }

        static void CountDictionary()
        {
            Dictionary<int, double> prices = new Dictionary<int, double>()
        {
            { 1, 99.50 },
            { 2, 150.75 },
            { 3, 200.25 }
        };

            Console.WriteLine(prices.Count);
        }

        static void CopyDictionary()
        {
            Dictionary<int, string> original = new Dictionary<int, string>()
        {
            { 101, "Mahendra" },
            { 102, "Madan" }
        };

            Dictionary<int, string> copy =
                new Dictionary<int, string>(original);

            Console.WriteLine(copy[101]);
        }

        static void PassDictionaryToMethod()
        {
            Dictionary<int, string> students = new Dictionary<int, string>()
        {
            { 101, "Mahendra" },
            { 102, "Madan" }
        };

            DisplayStudents(students);
        }

        static void DisplayStudents(Dictionary<int, string> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.Key + " " + student.Value);
            }
        }

        static Dictionary<string, int> ReturnDictionaryFromMethod()
        {
            return new Dictionary<string, int>()
        {
            { "Java", 85 },
            { "CSharp", 90 }
        };
        }

        static void DifferentDataTypes()
        {
            Dictionary<string, object> values = new Dictionary<string, object>()
        {
            { "Name", "Mahendra" },
            { "Age", 24 },
            { "Salary", 25000.50 },
            { "Grade", 'A' },
            { "IsActive", true }
        };

            foreach (var item in values)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        static void ClearDictionary()
        {
            Dictionary<int, string> students = new Dictionary<int, string>()
        {
            { 101, "Mahendra" },
            { 102, "Madan" }
        };

            students.Clear();

            Console.WriteLine(students.Count);
        }
    }
}
