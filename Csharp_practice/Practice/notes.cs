using AbstractionDemo;
using Csharp_practice.Practice;
using Csharp_practice.step_5;
using InterfaceDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Csharp_practice.Practice
{
    internal class notes
    {
    }
}


//* # C# OOP Concepts – Revision Notes

//## 1. Abstraction

//**Definition:**Hiding internal implementation details and exposing only the required functionality to other developers.

//**Purpose:**
//-Hide unnecessary implementation details.
//- Expose only required operations.
//- Reduce complexity for developers using the code.
//-Define what functionality should be available without exposing how it works.

//**Ways to achieve abstraction:**
//-Abstract classes
//- Interfaces

//* *Abstract class:**
//- Declared using the `abstract` keyword.
//- Cannot create objects directly.
//- Can contain abstract methods and normal implemented methods.
//- Can contain fields, properties and constructors.
//- A concrete child class must implement all inherited abstract methods.

//```csharp
//abstract class Animal
//{
//    public abstract void Sound();

//    public void Eat()
//    {
//        Console.WriteLine("Eating");
//    }
//}

//class Dog : Animal
//{
//    public override void Sound()
//    {
//        Console.WriteLine("Barking");
//    }
//}
//```

//**Interface:**
//-Defines a contract that implementing classes must follow.
//- A class can implement multiple interfaces.
//- Different classes can implement the same interface differently.
//-Useful for defining common capabilities without requiring common inheritance.

//```csharp
//interface IPayment
//{
//    void Pay();
//}

//class UpiPayment : IPayment
//{
//    public void Pay()
//    {
//        Console.WriteLine("UPI Payment");
//    }
//}
//```

//## 2. Encapsulation

//**Definition:**Bundling data and methods inside a class and controlling access to its internal data.

//** Purpose:**
//-Protect data from uncontrolled access.
//- Apply validation before changing values.
//- Control how data is accessed and modified.
//- Improve maintainability.

//**Common implementation:**Private fields + Public properties.

//```csharp
//class Employee
//{
//    private double salary;

//    public double Salary
//    {
//        get { return salary; }
//        set
//        {
//            if (value >= 0)
//                salary = value;
//        }
//    }
//}
//```

//Key points:
//- `private` prevents direct access from outside the class.
//- `get` reads the value.
//- `set` updates the value.
//- Validation can be applied inside `set`.

//## 3. Polymorphism

//**Definition:**One common method or contract can represent different behaviours depending on the situation or actual object.

//Two main types:

//### A. Compile-time polymorphism

//The compiler determines which implementation to use.

//**1. Method Overloading**

//Same method name with different parameter lists.

//```csharp
//class Calculator
//{
//    public int Add(int a, int b)
//    {
//        return a + b;
//    }

//    public double Add(double a, double b)
//    {
//        return a + b;
//    }
//}
//```

//Remember:
//-Same method name.
//-Different number, types or order of parameters.
//- Return type alone cannot distinguish overloaded methods.

//**2. Operator Overloading**

//Defining how existing operators behave when used with custom class objects.

//```csharp
//class Number
//{
//    public int Value { get; set; }

//    public Number(int value)
//    {
//        Value = value;
//    }

//    public static Number operator +(Number a, Number b)
//    {
//        return new Number(a.Value + b.Value);
//    }
//}
//```

//Usage:

//```csharp
//Number n1 = new Number(10);
//Number n2 = new Number(20);

//Number result = n1 + n2;
//```

//Remember:
//- `operator +` defines the overloaded operator.
//- `Number` is the return type.
//- `a` and `b` are the operands.
//- `new Number(...)` creates and returns the result object.
//- Operator overloads do not have normal method names.
//- Operator overload declarations must be `public static`.

//### B. Runtime polymorphism

//**Definition:**The implementation to execute is determined at runtime based on the actual object type.

//Commonly achieved through:

//**1.Method Overriding(`virtual` and `override`) * *

//```csharp
//class Animal
//{
//    public virtual void Sound()
//    {
//        Console.WriteLine("Animal sound");
//    }
//}

//class Dog : Animal
//{
//    public override void Sound()
//    {
//        Console.WriteLine("Dog barks");
//    }
//}
//```

//Usage:

//```csharp
//Animal obj = new Dog();

//obj.Sound();
//```

//Output: `Dog barks`

//Important keywords:
//- `virtual`: Allows a parent method to be overridden.
//- `override`: Provides a new implementation in the child class.

//Remember:
//-Reference type = `Animal`
//- Actual object type = `Dog`
//- Runtime dispatch executes `Dog.Sound()`.

//**2. Interface-based polymorphism**

//```csharp
//interface IPayment
//{
//    void Pay();
//}

//class UpiPayment : IPayment
//{
//    public void Pay()
//    {
//        Console.WriteLine("UPI Payment");
//    }
//}

//class CardPayment : IPayment
//{
//    public void Pay()
//    {
//        Console.WriteLine("Card Payment");
//    }
//}
//```

//Usage:

//```csharp
//IPayment payment = new UpiPayment();
//payment.Pay();

//payment = new CardPayment();
//payment.Pay();
//```

//The same interface reference can work with different implementations.

//**Advantages of polymorphism:**
//-Code reusability.
//- Easy extensibility.
//- Less conditional logic.
//-Loose coupling.
//- Different implementations can be used through a common contract.

//## 4. Abstract Class vs Interface

//| Abstract class | Interface |
//| ---| ---|
//| Used for related classes sharing common functionality and state | Used to define a common contract or capability |
//| Can contain fields and constructors | Cannot contain instance fields or instance constructors |
//| Can contain implemented and abstract methods | Can declare contracts and support default implementations |
//| A class can inherit only one class | A class can implement multiple interfaces |
//| Uses `abstract` and `override` | Uses interface implementation |

//**Remember:**
//-Use an abstract class when you want to share common properties, data and implementation.
//- Use an interface when you want different classes to follow a common contract.
//- An interface is also a way to achieve abstraction.

//## 5. Dependency Injection (DI)

//**Definition:**Providing the required objects(dependencies) to a class from outside instead of creating those objects inside the class.

//**Purpose:**
//-Reduce tight coupling.
//-Improve testability.
//- Make implementations replaceable.
//-Improve maintainability and flexibility.

//### Without DI

//```csharp
//class EmployeeService
//{
//    EmployeeRepository repository = new EmployeeRepository();
//}
//```

//Problem: The service directly creates and depends on a specific repository implementation.

//### With DI

//First define the interface:

//```csharp
//interface IEmployeeRepository
//{
//    void GetEmployees();
//}
//```

//Implementation:

//```csharp
//class EmployeeRepository : IEmployeeRepository
//{
//    public void GetEmployees()
//    {
//        Console.WriteLine("Fetching employees");
//    }
//}
//```

//Service:

//```csharp
//class EmployeeService
//{
//    private readonly IEmployeeRepository repository;

//    public EmployeeService(IEmployeeRepository repository)
//    {
//        this.repository = repository;
//    }

//    public void GetEmployeeDetails()
//    {
//        repository.GetEmployees();
//    }
//}
//```

//Remember:
//- Service depends on the interface.
//- Repository implements the interface.
//- The object is received through the constructor.
//- This is called **Constructor Injection**.

//### DI in ASP.NET Core

//Registration in `Program.cs`:

//```csharp
//builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
//builder.Services.AddScoped<IEmployeeService, EmployeeService>();
//```

//These registrations tell the DI container which implementation to provide when a dependency is requested.

//### Three DI lifetimes

//| Lifetime | Meaning |
//|---|---|
//| Transient | New instance every time requested |
//| Scoped | One instance per request scope |
//| Singleton | One instance for the application's lifetime |

//## 6. How Abstraction, Polymorphism and DI work together

//Example: ASP.NET Core Employee Application.

//```text
//EmployeeController
//       |
//       v
//IEmployeeService
//       |
//       v
//EmployeeService
//       |
//       v
//IEmployeeRepository
//       |
//       v
//EmployeeRepository
//```

//**Role of each concept:**

//- Abstraction: Interfaces hide implementation details and expose contracts.
//- Polymorphism: Different implementations can be used through the same interface.
//- Dependency Injection: Supplies the required implementation automatically.
//- Encapsulation: Each class controls access to its internal data and functionality.

//### Important DI registrations

//```csharp
//builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
//builder.Services.AddScoped<IEmployeeService, EmployeeService>();
//```

//The controller receives `IEmployeeService`, and the service receives `IEmployeeRepository`.

//**Important:** DI does not require interfaces. It can inject concrete classes too.

//## 7. Quick Interview Revision

//| Question | Short answer |
//|---|---|
//| What is abstraction? | Hiding implementation details and exposing required functionality. |
//| What is encapsulation? | Bundling data and methods and controlling access to internal data. |
//| What is polymorphism? | One common contract or method can provide different behaviours. |
//| Types of polymorphism? | Compile-time and runtime. |
//| What is method overloading? | Same method name with different parameter lists. |
//| What is operator overloading? | Defining operator behaviour for custom types. |
//| What is method overriding? | Child class provides its own implementation of a virtual parent method. |
//| What is runtime polymorphism? | Method implementation is selected at runtime based on actual object type. |
//| What is an interface? | A contract that implementing classes follow. |
//| What is DI? | Providing dependencies from outside instead of creating them inside a class. |
//| What is constructor injection? | Supplying dependencies through a class constructor. |
//| Does DI require interfaces? | No. Concrete classes can also be injected. |
//| What is loose coupling? | Classes depend less on specific implementations. |

//**Final memory tip:**

//- Abstraction = What to expose.
//- Encapsulation = How to protect data.
//- Polymorphism = How different objects provide different behaviours.
//- Dependency Injection = How required objects are supplied. *//
