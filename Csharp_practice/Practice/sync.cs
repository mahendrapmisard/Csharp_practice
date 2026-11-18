using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Csharp_practice.Practice
{
    class sync
    {

        public void first()
        {
            Thread.Sleep(1000);
            Console.WriteLine("first step executed");
        }

        public void second()
        {
            Thread.Sleep(2000);
            Console.WriteLine("second step executed");
        }

        public void third()
        {
            Thread.Sleep(3000);
            Console.WriteLine("third step is executed");
        }
    
    }
    class program2
    {

        public static void program2fun() {
            sync obj = new sync();
            obj.first();
            obj.second();
            obj.third();

        }

        public static void Main()
        {
            program2.program2fun();

        }
    }

    class program3
    {

    }
}
