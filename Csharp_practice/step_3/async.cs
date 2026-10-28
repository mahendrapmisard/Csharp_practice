using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.step_3
{
    class async
    {
        public void ticketcounter()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Ticket is taken from the ticket collector");
        }

        public void dharshanam()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Dharshanam is completed");
        }

        public void ladducounter()
        {
            Thread.Sleep(2000);
            Console.WriteLine("collected laddu from counter");
        }


        public void varahidharshanam()
        {
            Console.WriteLine("completed varahi dharshasnam");
        }
    }

    class AsyncProgram
    {
        public static void Main()
        {
            async obj = new async();
            obj.ticketcounter();
            obj.dharshanam();
            obj.ladducounter();
            obj.varahidharshanam();
        }
    }
}
