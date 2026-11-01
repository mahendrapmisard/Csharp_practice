using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.step_4
{
    class HashtablePractice
    {
        public static void Main()
        {
            CreateHashtable();
            DifferentDataTypes();
            ReadHashtable();
            UpdateValue();
            AddElement();
            InsertOrUpdate();
            DeleteElement();
            SearchHashtable();
            LoopHashtable();
            GetKeysAndValues();
            TryGetValueExample();
            CountHashtable();
            CopyHashtable();
            CloneHashtable();
            PassHashtableToMethod();
            Console.WriteLine(ReturnHashtableFromMethod()["CSharp"]);
            ClearHashtable();
        }

        static void CreateHashtable()
        {
            Hashtable students = new Hashtable()
            {
                { 101, "Mahendra" },
                { 102, "Madan" },
                { 103, "Kavya" }
            };

            Console.WriteLine(students[101]);
        }

        static void DifferentDataTypes()
        {
            Hashtable values = new Hashtable();

            values.Add("Name", "Mahendra");
            values.Add("Age", 24);
            values.Add("Salary", 25000.50);
            values.Add("Grade", 'A');
            values.Add("IsActive", true);

            foreach (DictionaryEntry item in values)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        static void ReadHashtable()
        {
            Hashtable marks = new Hashtable()
            {
                { "Java", 85 },
                { "CSharp", 90 },
                { "Angular", 80 }
            };

            Console.WriteLine(marks["CSharp"]);
        }

        static void UpdateValue()
        {
            Hashtable students = new Hashtable()
            {
                { 101, "Mahendra" },
                { 102, "Madan" }
            };

            students[101] = "Ravi";

            Console.WriteLine(students[101]);
        }

        static void AddElement()
        {
            Hashtable students = new Hashtable();

            students.Add(101, "Mahendra");
            students.Add(102, "Madan");

            Console.WriteLine(students.Count);
        }

        static void InsertOrUpdate()
        {
            Hashtable students = new Hashtable();

            students[101] = "Mahendra";
            students[102] = "Madan";
            students[101] = "Ravi";

            Console.WriteLine(students[101]);
        }

        static void DeleteElement()
        {
            Hashtable students = new Hashtable()
            {
                { 101, "Mahendra" },
                { 102, "Madan" },
                { 103, "Kavya" }
            };

            students.Remove(102);

            Console.WriteLine(students.Count);
        }

        static void SearchHashtable()
        {
            Hashtable students = new Hashtable()
            {
                { 101, "Mahendra" },
                { 102, "Madan" }
            };

            Console.WriteLine(students.ContainsKey(101));
            Console.WriteLine(students.ContainsKey(105));
            Console.WriteLine(students.ContainsValue("Madan"));
        }

        static void LoopHashtable()
        {
            Hashtable students = new Hashtable()
            {
                { 101, "Mahendra" },
                { 102, "Madan" },
                { 103, "Kavya" }
            };

            foreach (DictionaryEntry student in students)
            {
                Console.WriteLine(student.Key + " " + student.Value);
            }
        }

        static void GetKeysAndValues()
        {
            Hashtable students = new Hashtable()
            {
                { 101, "Mahendra" },
                { 102, "Madan" }
            };

            foreach (object key in students.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (object value in students.Values)
            {
                Console.WriteLine(value);
            }
        }

        static void TryGetValueExample()
        {
            Hashtable students = new Hashtable()
            {
                { 101, "Mahendra" },
                { 102, "Madan" }
            };

            if (students.ContainsKey(101))
            {
                Console.WriteLine(students[101]);
            }

            if (!students.ContainsKey(105))
            {
                Console.WriteLine("Key not found");
            }
        }

        static void CountHashtable()
        {
            Hashtable prices = new Hashtable()
            {
                { 1, 99.50 },
                { 2, 150.75 },
                { 3, 200.25 }
            };

            Console.WriteLine(prices.Count);
        }

        static void CopyHashtable()
        {
            Hashtable original = new Hashtable()
            {
                { 101, "Mahendra" },
                { 102, "Madan" }
            };

            Hashtable copy = new Hashtable(original);

            Console.WriteLine(copy[101]);
        }

        static void CloneHashtable()
        {
            Hashtable original = new Hashtable()
            {
                { "Java", 85 },
                { "CSharp", 90 }
            };

            Hashtable copy = (Hashtable)original.Clone();

            Console.WriteLine(copy["CSharp"]);
        }

        static void PassHashtableToMethod()
        {
            Hashtable students = new Hashtable()
            {
                { 101, "Mahendra" },
                { 102, "Madan" }
            };

            DisplayStudents(students);
        }

        static void DisplayStudents(Hashtable students)
        {
            foreach (DictionaryEntry student in students)
            {
                Console.WriteLine(student.Key + " " + student.Value);
            }
        }

        static Hashtable ReturnHashtableFromMethod()
        {
            return new Hashtable()
            {
                { "Java", 85 },
                { "CSharp", 90 }
            };
        }

        static void ClearHashtable()
        {
            Hashtable students = new Hashtable()
            {
                { 101, "Mahendra" },
                { 102, "Madan" }
            };

            students.Clear();

            Console.WriteLine(students.Count);
        }
    }
}