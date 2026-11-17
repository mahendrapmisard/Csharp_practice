using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.Practice
{
    public class Oops
    {

        int id { get; set; } = 0;
        string name { get; set; } = "misard";

        double salary { get; set; } = 0;

        public Oops(int id, string name , double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

       

        public void displayemployee()
        {
            Console.WriteLine("employee id " + this.id);
            Console.WriteLine("employee name " + this.name);
            Console.WriteLine("employee salary " + this.salary);
        }



    }


    class program
    {
        public static void Main()
        {

            Oops obj1 = new Oops(1, "mahendra", 10000);
            obj1.displayemployee();


            Oops obj2 = new Oops(2, "madan", 10000);
            obj2.displayemployee();


            Oops obj3 = new Oops(3, "giri", 10000);
            obj3.displayemployee();

            //Oops obj4 = new Oops();


        }
    }
}
