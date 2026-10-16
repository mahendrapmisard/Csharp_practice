using System;



namespace AbstractionDemo
{
    abstract class Animal
    {
        public string Name { get; set; }

        protected Animal(string name)
        {
            Name = name;
        }

        public abstract void MakeSound();

        public abstract void Eat();

        public virtual void Sleep()
        {
            Console.WriteLine(Name + " is sleeping");
        }

        public void DisplayName()
        {
            Console.WriteLine("Animal name: " + Name);
        }

        public static void AnimalCategory()
        {
            Console.WriteLine("Animals are living organisms");
        }
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " barks");
        }

        public override void Eat()
        {
            Console.WriteLine(Name + " eats dog food");
        }

        public override void Sleep()
        {
            Console.WriteLine(Name + " sleeps in a kennel");
        }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " meows");
        }

        public override void Eat()
        {
            Console.WriteLine(Name + " eats fish");
        }
    }

    abstract class Shape
    {
        public string Color { get; set; }

        protected Shape(string color)
        {
            Color = color;
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public virtual void Display()
        {
            Console.WriteLine("Shape color: " + Color);
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, string color) : base(color)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Shape: Circle");
        }
    }

    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width, string color) : base(color)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }

    abstract class Vehicle
    {
        public string Brand { get; set; }

        protected Vehicle(string brand)
        {
            Brand = brand;
        }

        public abstract void Start();

        public abstract void Stop();

        public virtual void DisplayBrand()
        {
            Console.WriteLine("Brand: " + Brand);
        }
    }

    abstract class Car : Vehicle
    {
        protected Car(string brand) : base(brand)
        {
        }

        public abstract void Drive();
    }

    class ElectricCar : Car
    {
        public ElectricCar(string brand) : base(brand)
        {
        }

        public override void Start()
        {
            Console.WriteLine(Brand + " electric car starts silently");
        }

        public override void Stop()
        {
            Console.WriteLine(Brand + " electric car stops");
        }

        public override void Drive()
        {
            Console.WriteLine(Brand + " electric car is driving");
        }
    }

    abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        protected Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract double CalculateSalary();

        public virtual void DisplayDetails()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
        }
    }

    class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }

        public FullTimeEmployee(int id, string name, double salary)
            : base(id, name)
        {
            MonthlySalary = salary;
        }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public PartTimeEmployee(int id, string name, double rate, int hours)
            : base(id, name)
        {
            HourlyRate = rate;
            HoursWorked = hours;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }

    abstract class Payment
    {
        public decimal Amount { get; set; }

        protected Payment(decimal amount)
        {
            Amount = amount;
        }

        public abstract void ProcessPayment();

        public virtual void DisplayAmount()
        {
            Console.WriteLine("Payment amount: " + Amount);
        }
    }

    class CreditCardPayment : Payment
    {
        public CreditCardPayment(decimal amount) : base(amount)
        {
        }

        public override void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment");
        }
    }

    class UpiPayment : Payment
    {
        public UpiPayment(decimal amount) : base(amount)
        {
        }

        public override void ProcessPayment()
        {
            Console.WriteLine("Processing UPI payment");
        }
    }

    abstract class Database
    {
        public abstract void Connect();
        public abstract void ExecuteQuery(string query);

        public virtual void Disconnect()
        {
            Console.WriteLine("Database disconnected");
        }
    }

    class SqlServerDatabase : Database
    {
        public override void Connect()
        {
            Console.WriteLine("Connected to SQL Server");
        }

        public override void ExecuteQuery(string query)
        {
            Console.WriteLine("Executing SQL Server query: " + query);
        }
    }

    class Abstractions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ABSTRACT ANIMAL CLASS ===");

            Animal dog = new Dog("Tommy");
            dog.DisplayName();
            dog.MakeSound();
            dog.Eat();
            dog.Sleep();

            Animal cat = new Cat("Kitty");
            cat.MakeSound();
            cat.Eat();
            cat.Sleep();

            Animal.AnimalCategory();

            Console.WriteLine("\n=== ABSTRACT SHAPE CLASS ===");

            Shape circle = new Circle(5, "Red");
            circle.Display();
            Console.WriteLine("Circle area: " + circle.CalculateArea());
            Console.WriteLine("Circle perimeter: " + circle.CalculatePerimeter());

            Shape rectangle = new Rectangle(10, 5, "Blue");
            rectangle.Display();
            Console.WriteLine("Rectangle area: " + rectangle.CalculateArea());
            Console.WriteLine("Rectangle perimeter: " + rectangle.CalculatePerimeter());

            Console.WriteLine("\n=== MULTILEVEL ABSTRACTION ===");

            Car car = new ElectricCar("Tesla");
            car.DisplayBrand();
            car.Start();
            car.Drive();
            car.Stop();

            Console.WriteLine("\n=== EMPLOYEE ABSTRACTION ===");

            Employee fullTime = new FullTimeEmployee(1, "Ravi", 50000);
            fullTime.DisplayDetails();
            Console.WriteLine("Salary: " + fullTime.CalculateSalary());

            Employee partTime = new PartTimeEmployee(2, "Priya", 500, 80);
            partTime.DisplayDetails();
            Console.WriteLine("Salary: " + partTime.CalculateSalary());

            Console.WriteLine("\n=== PAYMENT ABSTRACTION ===");

            Payment creditCard = new CreditCardPayment(2500);
            creditCard.DisplayAmount();
            creditCard.ProcessPayment();

            Payment upi = new UpiPayment(1500);
            upi.DisplayAmount();
            upi.ProcessPayment();

            Console.WriteLine("\n=== DATABASE ABSTRACTION ===");

            Database database = new SqlServerDatabase();
            database.Connect();
            database.ExecuteQuery("SELECT * FROM Students");
            database.Disconnect();
        }
    }
}
