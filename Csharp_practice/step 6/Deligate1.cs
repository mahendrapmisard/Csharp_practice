using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Csharp_practice.step_6
{
    class Deligate1
    {

        delegate void messagep(string name);

        delegate string message2(string name);

        delegate bool IsAvailable(string name);
        public static void Main()
        {
            messagep dmess = greet;
            dmess("mahendra");

            //message2 dmessa2 = delegate (string name)
            //{
            //    return "this is string out of greet message " + name;
            //};


            message2 dmessa2 =  (string name) =>
            {
                return "this is string out of greet message " + name;
            };

            //message2 dmessa3 = greet2;

            string greetmes = dmessa2("sudharshan");
            Console.WriteLine(greetmes);


            Deligate1 obj = new Deligate1();
            IsAvailable availablity = obj.isavail;
            bool availres = availablity("");

            Console.WriteLine(availres);


            Action<string> logger = (string text) =>
            {
                Console.WriteLine(text);
            };






        }
            public static void greet(string name) {
            Console.WriteLine("Good Morning " + name); 
        }


        internal static string greet2(string name)
        {
            return "this is string out of greet message " + name;
        }

        private bool isavail(string name)
        {
            if(name == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
            
        }
 }

