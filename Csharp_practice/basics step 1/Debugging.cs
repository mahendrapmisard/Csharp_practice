using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice
{

     class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 70, 85, 40, 95 };
            int total = 0;


            Console.WriteLine("Student Marks");

            for (int i = 0; i < marks.Length; i++)
            {
                total = total + marks[i];

                DisplayMark(marks[i]);
            }

            double average = CalculateAverage(total, marks.Length);

            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Average Marks: " + average);
        }

        static void DisplayMark(int mark)
        {
            if (mark >= 50)
            {
                Console.WriteLine(mark + " - Pass");
            }
            else
            {
                Console.WriteLine(mark + " - Fail");
            }
        }

        static double CalculateAverage(int total, int count)
        {
            return (double)total / count;
        }
    }
}
