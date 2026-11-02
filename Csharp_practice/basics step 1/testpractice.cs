using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.basics_step_1
{
    class testpractice
    {


        static void Main()
        {
            //Console.WriteLine("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your id");
            //String input_id = Console.ReadLine();
            //int id = Convert.ToInt32(input_id);
            //Console.WriteLine("enter the rating: ");
            //int rating = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the salary: ");
            //double salary = Convert.ToDouble(Console.ReadLine());

            //double bonus = Bonuscalulator(rating, salary);


            //Console.WriteLine("employee name " + name);

            //Console.WriteLine("employee id " + id);
            //Console.WriteLine("employee salary " + salary);
            //Console.WriteLine("employee bonus " + bonus);
            //Console.WriteLine("employee total salary " + (salary + bonus));


            //Console.WriteLine("Enter any number please :  ");
            //int EnteredNumber = Convert.ToInt32(Console.ReadLine());
            //string funout =  checki(EnteredNumber);
            //Console.WriteLine(funout);
            //string funout1 = checkii(EnteredNumber);
            //Console.WriteLine(funout1);
            //checkiii(EnteredNumber);
            //Console.ReadLine();


        }
        public static double Bonuscalulator(int rating, double salary)
        {
            double bonus = 0;

            if (rating == 5)
            {
                bonus = (salary * 0.2);
            }
            else if (rating == 4)
            {
                bonus = (salary * 0.15);
            }
            else if (rating == 3)
            {
                bonus = (salary * 0.1);
            }

            return bonus;
        }


        public static string checki(int number)
        {
            if (number > 0)
            {
                return "positive";
            }
            else if (number == 0)
            {
                return "Zero";
            }
            else
            {
                return "negative";
            }
        }


        public static string checkii(int num)
        {
            if (num % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }

        //public static int checkiii(int num)
        //{
        //    if (num < 0)
        //    {
        //        return -1;
        //    }

        //    else
        //    {
        //        int sum = 0;

        //        int temp = num % 10;
        //        int temp2 = num - temp;
        //        sum = sum + 
        //        temp = temp2 / 10;
        //        sum =
        //    }

        //} 
        public static void checkiii(int num)
        {
            if (num > 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(num + "*" + i + "=" + (num * i));
                }
            }
        }


    }

}
