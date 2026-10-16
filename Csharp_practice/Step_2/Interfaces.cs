using System;


namespace InterfaceDemo
{
    interface IAnimal
    {
        void MakeSound();
        void Eat();

        void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
    }

    class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }

        public void Eat()
        {
            Console.WriteLine("Dog eats food");
        }
    }

    interface IFlyable
    {
        void Fly();
    }

    interface ISwimmable
    {
        void Swim();
    }

    class Duck : IAnimal, IFlyable, ISwimmable
    {
        public void MakeSound()
        {
            Console.WriteLine("Duck quacks");
        }

        public void Eat()
        {
            Console.WriteLine("Duck eats");
        }

        public void Fly()
        {
            Console.WriteLine("Duck flies");
        }

        public void Swim()
        {
            Console.WriteLine("Duck swims");
        }
    }

    interface IVehicle
    {
        void Start();
    }

    interface ICar : IVehicle
    {
        void Drive();
    }

    class SportsCar : ICar
    {
        public void Start()
        {
            Console.WriteLine("Sports car starts");
        }

        public void Drive()
        {
            Console.WriteLine("Sports car drives");
        }
    }

    interface ILogger
    {
        void Log(string message);
    }

    interface IDataService
    {
        void Save();
    }

    class DatabaseService : ILogger, IDataService
    {
        public void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }

        public void Save()
        {
            Console.WriteLine("Data saved");
        }
    }

    interface ICalculator
    {
        int Add(int a, int b);
        int Multiply(int a, int b);
    }

    class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    interface IPrinter
    {
        void Print();
    }

    interface IScanner
    {
        void Scan();
    }

    class MultiFunctionDevice : IPrinter, IScanner
    {
        void IPrinter.Print()
        {
            Console.WriteLine("Printing document");
        }

        void IScanner.Scan()
        {
            Console.WriteLine("Scanning document");
        }
    }

    interface IMessage
    {
        void Send()
        {
            Console.WriteLine("Default message sent");
        }
    }

    class EmailMessage : IMessage
    {
        public void Send()
        {
            Console.WriteLine("Email sent");
        }
    }

    class Notification : IMessage
    {
    }

    interface IShape
    {
        double Area { get; }
        string Name { get; set; }
    }

    class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area
        {
            get { return Length * Width; }
        }

        public string Name { get; set; }

        public Rectangle(double length, double width, string name)
        {
            Length = length;
            Width = width;
            Name = name;
        }
    }

    interface IRepository<T>
    {
        void Add(T item);
        T GetById(int id);
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class StudentRepository : IRepository<Student>
    {
        public void Add(Student item)
        {
            Console.WriteLine("Added student: " + item.Name);
        }

        public Student GetById(int id)
        {
            return new Student { Id = id, Name = "Mahendra" };
        }
    }

    interface IWorker
    {
        void Work();
    }

    class Employee : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Employee is working");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog();
            dog.MakeSound();
            dog.Eat();
            dog.Sleep();

            Duck duck = new Duck();
            duck.MakeSound();
            duck.Eat();
            duck.Fly();
            duck.Swim();

            ICar car = new SportsCar();
            car.Start();
            car.Drive();

            DatabaseService database = new DatabaseService();
            database.Log("Application started");
            database.Save();

            ICalculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(10, 20));
            Console.WriteLine(calculator.Multiply(5, 4));

            MultiFunctionDevice device = new MultiFunctionDevice();
            ((IPrinter)device).Print();
            ((IScanner)device).Scan();

            IMessage email = new EmailMessage();
            email.Send();

            IMessage notification = new Notification();
            notification.Send();

            Rectangle rectangle = new Rectangle(10, 5, "Rectangle");
            Console.WriteLine(rectangle.Name);
            Console.WriteLine(rectangle.Area);

            IRepository<Student> repository = new StudentRepository();
            repository.Add(new Student { Id = 1, Name = "Ravi" });

            Student student = repository.GetById(1);
            Console.WriteLine(student.Id + " " + student.Name);

            IWorker worker = new Employee();
            worker.Work();
        }
    }
}
