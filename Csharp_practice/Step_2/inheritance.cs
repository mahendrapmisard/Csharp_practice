using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.Step_2
{
    class Animal
    {
        public string Name;

        public Animal(string name)
        {
            Name = name;
            Console.WriteLine("Animal constructor called");
        }

        public void Eat()
        {
            Console.WriteLine(Name + " is eating");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            Console.WriteLine("Dog constructor called");
        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " says Woof!");
        }

        public void Guard()
        {
            Console.WriteLine(Name + " is guarding");
        }
    }

    class Puppy : Dog
    {
        public Puppy(string name) : base(name)
        {
            Console.WriteLine("Puppy constructor called");
        }

        public void Play()
        {
            Console.WriteLine(Name + " is playing");
        }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " says Meow!");
        }
    }

    abstract class Shape
    {
        public abstract double CalculateArea();

        public void Display()
        {
            Console.WriteLine("This is a shape");
        }
    }

    class Circle : Shape
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    interface IPrintable
    {
        void Print();
    }

    class Report : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Printing report");
        }
    }
    interface ISavable
    {
        void Save();
    }

    class Document : IPrintable, ISavable
    {
        public void Print()
        {
            Console.WriteLine("Printing document");
        }

        public void Save()
        {
            Console.WriteLine("Saving document");
        }
    }

    class Cinheritance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SINGLE INHERITANCE ===");

            Dog dog = new Dog("Tommy");
            dog.Eat();
            dog.MakeSound();
            dog.Guard();

            Console.WriteLine("\n=== MULTILEVEL INHERITANCE ===");

            Puppy puppy = new Puppy("Bruno");
            puppy.Eat();
            puppy.MakeSound();
            puppy.Guard();
            puppy.Play();

            Console.WriteLine("\n=== HIERARCHICAL INHERITANCE ===");

            Cat cat = new Cat("Kitty");
            cat.Eat();
            cat.MakeSound();

    

            Console.WriteLine("\n=== BASE KEYWORD ===");

            Dog anotherDog = new Dog("Max");
            anotherDog.Eat();

            Console.WriteLine("\n=== ABSTRACT CLASS ===");

            Shape shape = new Circle(5);
            shape.Display();
            Console.WriteLine("Circle area: " + shape.CalculateArea());

            Console.WriteLine("\n=== INTERFACE ===");

            IPrintable report = new Report();
            report.Print();

            Console.WriteLine("\n=== MULTIPLE INTERFACES ===");

            Document document = new Document();
            document.Print();
            document.Save();
        }
    }
}
