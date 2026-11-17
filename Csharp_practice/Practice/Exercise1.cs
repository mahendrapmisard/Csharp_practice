using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.Practice
{
    class Exercise1
    {

        private int marks;

        public int Marks
        {
            get;
            set
            {
                if (marks <= 100 && marks > 0)
                {
                    marks = value;
                }

            }
        }

        public int displaymarks()
            {
            return marks;
            }

        public static void Main()
        {
            Exercise1 obj = new Exercise1();
            obj.marks = 98;
            int marks = obj.displaymarks();

            Console.WriteLine(marks);
        }

    }
}
