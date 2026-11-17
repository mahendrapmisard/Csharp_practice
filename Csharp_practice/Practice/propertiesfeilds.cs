using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.Practice
{
class Student
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 18 && value <= 60)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Invalid age");
                }
            }
        }

        public string Name { get; set; }

        public int Marks
        {
            get;
            private set;
        }

        public void SetMarks(int marks)
        {
            if (marks >= 0 && marks <= 100)
            {
                Marks = marks;
            }
        }

        private int InternalAge
        {
            get
            {
                return field;
            }
            set
            {
                if (value >= 18)
                {
                    field = value;
                }
            }
        }

        public void SetInternalAge(int age)
        {
            InternalAge = age;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Marks: " + Marks);
            Console.WriteLine("Internal Age: " + InternalAge);
        }
    }

    class Program
    {
        static void Main()
        {
            Student student = new Student();

            student.Name = "Mahendra";

            student.Age = 24;
            student.Age = 15;

            student.SetMarks(85);

            student.SetInternalAge(25);

            student.Display();
        }
    }

}

