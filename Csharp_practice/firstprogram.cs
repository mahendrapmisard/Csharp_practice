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

        string[] employees = { "mahendra", "giridhar", "madan" };

        string company = "misard";
 
        for(int i = 0; i <employees.Length; i++)
        {
            
            if (employees[i] == "giridhar")
            {
                continue;
            }
            //Console.WriteLine(employees[i]);
            Console.WriteLine($"hi this is {employees[i]} and working in {company}");
        }

        string url = @"\https:\\www.google.co.in\mahendra";
        string newurl = "\\https:\\www\\https:\\\\www.google.co.in\\mahendra";
    }
}