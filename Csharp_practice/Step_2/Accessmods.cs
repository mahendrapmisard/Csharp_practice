using System;

namespace AccessModifiersDemo
{
    public class PublicClass
    {
        public string PublicField = "Public Field";
        private string PrivateField = "Private Field";
        protected string ProtectedField = "Protected Field";
        internal string InternalField = "Internal Field";
        protected internal string ProtectedInternalField = "Protected Internal Field";
        private protected string PrivateProtectedField = "Private Protected Field";

        public void DisplayInsideClass()
        {
            Console.WriteLine(PublicField);
            Console.WriteLine(PrivateField);
            Console.WriteLine(ProtectedField);
            Console.WriteLine(InternalField);
            Console.WriteLine(ProtectedInternalField);
            Console.WriteLine(PrivateProtectedField);
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Private method");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected method");
        }

        internal void InternalMethod()
        {
            Console.WriteLine("Internal method");
        }

        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected internal method");
        }

        private protected void PrivateProtectedMethod()
        {
            Console.WriteLine("Private protected method");
        }

        public void CallPrivateMethod()
        {
            PrivateMethod();
        }
    }

    public class DerivedClass : PublicClass
    {
        public void DisplayDerivedAccess()
        {
            Console.WriteLine(PublicField);
            Console.WriteLine(ProtectedField);
            Console.WriteLine(InternalField);
            Console.WriteLine(ProtectedInternalField);
            Console.WriteLine(PrivateProtectedField);

            ProtectedMethod();
            InternalMethod();
            ProtectedInternalMethod();
            PrivateProtectedMethod();
        }
    }

    internal class InternalClass
    {
        public void Display()
        {
            Console.WriteLine("Internal class accessible within this assembly");
        }
    }

    public class Student
    {
        private int marks;

        public int Marks
        {
            get { return marks; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    marks = value;
                }
            }
        }

        public string Name { get; private set; }

        public Student(string name)
        {
            Name = name;
        }
    }

    public class Account
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Balance: " + Balance);
        }
    }

    public abstract class Shape
    {
        public abstract double CalculateArea();

        protected void DisplayShape()
        {
            Console.WriteLine("This is a shape");
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            DisplayShape();
            return Math.PI * Radius * Radius;
        }
    }

    public static class Utility
    {
        public static void DisplayMessage()
        {
            Console.WriteLine("Static public method");
        }

        internal static void InternalUtility()
        {
            Console.WriteLine("Static internal method");
        }
    }

    public class Employee
    {
        public required string Name { get; set; }
        public int Id { get; init; }
    }

    public class BaseExample
    {
        public virtual void Display()
        {
            Console.WriteLine("Base class method");
        }
    }

    public class ChildExample : BaseExample
    {
        public override void Display()
        {
            Console.WriteLine("Derived class method");
        }
    }

    class Accessmods
    {
        static void Main(string[] args)
        {

            PublicClass obj = new PublicClass();

            Console.WriteLine(obj.PublicField);
            Console.WriteLine(obj.InternalField);
            Console.WriteLine(obj.ProtectedInternalField);

            obj.DisplayInsideClass();
            obj.CallPrivateMethod();


            DerivedClass derived = new DerivedClass();
            derived.DisplayDerivedAccess();


            InternalClass internalObj = new InternalClass();
            internalObj.Display();


            Student student = new Student("Mahendra");
            student.Marks = 85;

            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Marks: " + student.Marks);

            student.Marks = 150;
            Console.WriteLine("Marks after invalid update: " + student.Marks);


            Account account = new Account(1000);
            account.Deposit(500);
            account.DisplayBalance();


            Shape circle = new Circle(5);
            Console.WriteLine("Area: " + circle.CalculateArea());


            Utility.DisplayMessage();
            Utility.InternalUtility();

            Employee employee = new Employee
            {
                Name = "Ravi",
                Id = 101
            };

            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Id);


            BaseExample example = new ChildExample();
            example.Display();
        }
    }
}
