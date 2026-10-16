using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice
{
 class child
    {


        public int age = 24;
        public string name = "mahendra";
    }

 class classandobj
    {
        public void display()
        {
            Console.WriteLine("this is parent class");
        }
        static void Main()
        {
            child obj = new child();
            Console.WriteLine(obj.age);
            Console.WriteLine(obj.name);
        }
    }
}
