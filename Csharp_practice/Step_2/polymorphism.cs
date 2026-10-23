using System;
namespace polymorphism
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    abstract class Shape
    {
        public abstract double CalculateArea();

        public virtual void Display()
        {
            Console.WriteLine("This is a shape");
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Display()
        {
            Console.WriteLine("This is a circle");
        }
    }

    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override void Display()
        {
            Console.WriteLine("This is a rectangle");
        }
    }

    interface IPayment
    {
        void Pay(decimal amount);
    }

    class CreditCardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card");
        }
    }

    class UpiPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using UPI");
        }
    }

    class Number
    {
        public int Value { get; set; }

        public Number(int value)
        {
            Value = value;
        }

        public static Number operator +(Number a, Number b)
        {
            return new Number(a.Value + b.Value);
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(10, 20));
            Console.WriteLine(calculator.Add(10, 20, 30));
            Console.WriteLine(calculator.Add(2.5, 3.5));

            Animal[] animals = { new Dog(), new Cat(), new Animal() };

            foreach (Animal animal in animals)
            {
                animal.Sound();
            }

            Shape[] shapes =
            {
            new Circle(5),
            new Rectangle(4, 6)
        };

            foreach (Shape shape in shapes)
            {
                shape.Display();
                Console.WriteLine($"Area: {shape.CalculateArea():F2}");
            }

            IPayment[] payments =
            {
            new CreditCardPayment(),
            new UpiPayment()
        };

            foreach (IPayment payment in payments)
            {
                payment.Pay(1000);
            }

            Number n1 = new Number(10);
            Number n2 = new Number(20);
            Number result = n1 + n2;

            Console.WriteLine($"Operator Overloading: {result.Value}");
        }
    }
}