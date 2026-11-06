using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.step_7
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    class SalaryCalculator
    {
        public double CalculateBonus(Employee employee)
        {
            return employee.Salary * 0.10;
        }

        public double CalculateFinalSalary(Employee employee)
        {
            return employee.Salary + CalculateBonus(employee);
        }
    }

    class EmployeeRepository
    {
        public void Save(Employee employee)
        {
            Console.WriteLine($"{employee.Name} saved to database.");
        }
    }

    class EmployeeReport
    {
        public void Generate(Employee employee, SalaryCalculator calculator)
        {
            Console.WriteLine("\n----- EMPLOYEE REPORT -----");

            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Salary: {employee.Salary}");
            Console.WriteLine($"Bonus: {calculator.CalculateBonus(employee)}");
            Console.WriteLine($"Final Salary: {calculator.CalculateFinalSalary(employee)}");
        }
    }

    class Program
    {
       public static void Main()
        {
            Employee employee = new Employee("Mahendra", 30000);

            SalaryCalculator calculator = new SalaryCalculator();

            EmployeeRepository repository = new EmployeeRepository();

            EmployeeReport report = new EmployeeReport();

            repository.Save(employee);

            report.Generate(employee, calculator);
        }
    }
}
