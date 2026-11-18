using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.Practice
{
    class Exercise3
    {

        public void greet()
        {
            Console.WriteLine("good morning");
        }
    }

    class Exericse4 : Exercise3
    {
        public void greet()
        {
            Console.WriteLine("good evening");
        }

    }

    class inheritance
        {
        public static void Main()
        {
            Exercise3 obj = new Exericse4();
            obj.greet();
        }

        }
}
