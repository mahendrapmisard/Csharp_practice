using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.step_5
{
    class Parent
    {
  
            public string PublicName = "Public";
            private string PrivateName = "Private";
            protected string ProtectedName = "Protected";
            internal string InternalName = "Internal";
            protected internal string ProtectedInternalName = "Protected Internal";
            private protected string PrivateProtectedName = "Private Protected";

            public void DisplayInsideClass()
            {
                Console.WriteLine(PublicName);
                Console.WriteLine(PrivateName);
                Console.WriteLine(ProtectedName);
                Console.WriteLine(InternalName);
                Console.WriteLine(ProtectedInternalName);
                Console.WriteLine(PrivateProtectedName);
            }
        }

        class Child : Parent
        {
            public void DisplayInsideChild()
            {
                Console.WriteLine(PublicName);
                Console.WriteLine(ProtectedName);
                Console.WriteLine(InternalName);
                Console.WriteLine(ProtectedInternalName);
                Console.WriteLine(PrivateProtectedName);
            }
        }

        class Unrelated
        {
            public void Display()
            {
                Parent p = new Parent();

                Console.WriteLine(p.PublicName);
                Console.WriteLine(p.InternalName);
                Console.WriteLine(p.ProtectedInternalName);

            }
        }

        class Program
        {
            static void Main()
            {
                Parent p = new Parent();
                p.DisplayInsideClass();

                Console.WriteLine(p.PublicName);
                Console.WriteLine(p.InternalName);
                Console.WriteLine(p.ProtectedInternalName);

                Child c = new Child();
                c.DisplayInsideChild();

                Unrelated u = new Unrelated();
                u.Display();
            }
        }
    }

