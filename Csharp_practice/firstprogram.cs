using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Csharp_practice
//{
//    internal class firstprogram
//    {
//    }
//}


class firstprogram
{
    static void Main()
    {
        //Console.WriteLine("hi this is first csharp program");

        

        string company = "misard";


        int age = 25;
        string name = "Mahendra";
        double salary = 45000.50;
        bool isEmployee = true;

        Console.WriteLine(name);
        Console.WriteLine(age);

        const double PI = 3.14159;

        Console.WriteLine(PI);

        Console.WriteLine(company); 

        

        string url = @"\https:\\www.google.co.in\mahendra";
        string newurl = "\\https:\\www\\https:\\\\www.google.co.in\\mahendra";


        Console.Write("Enter your name: ");

        string name = Console.ReadLine();

        Console.WriteLine("Hello " + name);

        int a = 10;
        int b = 5;

        Console.WriteLine(a + b); // 15
        Console.WriteLine(a - b); // 5
        Console.WriteLine(a * b); // 50
        Console.WriteLine(a / b); // 2
        Console.WriteLine(a % b); // 0



        int Age_2 = 25;

        Console.WriteLine(Age_2 == 25);
        Console.WriteLine(Age_2 != 20);
        Console.WriteLine(Age_2 > 18);
        Console.WriteLine(Age_2 < 30);
        Console.WriteLine(Age_2 >= 25);
        Console.WriteLine(Age_2 <= 30);

        int marks = 75;

        if (marks >= 90)
        {
            Console.WriteLine("A grade");
        }
        else if (marks >= 75)
        {
            Console.WriteLine("B brage");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("C grade");
        }
        else
        {
            Console.WriteLine("Fail, sorry buddy");
        }


        string[] employees = { "mahendra", "giridhar", "madan" };


        for (int i = 0; i < employees.Length; i++)
        {

            if (employees[i] == "giridhar")
            {
                continue;
            }
            //Console.WriteLine(employees[i]);
            Console.WriteLine($"hi this is {employees[i]} and working in {company}");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        int result = Add(10, 20);

        Console.WriteLine(result);
    }
}