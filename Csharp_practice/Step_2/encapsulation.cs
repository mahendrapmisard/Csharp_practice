using System;

class Employee
{
    private int salary;
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Salary
    {
        get { return salary; }
        private set
        {
            if (value > 0)
                salary = value;
        }
    }

    public Employee(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }

    public void IncreaseSalary(int amount)
    {
        if (amount > 0)
            Salary += amount;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: {Salary}");
    }
}

class BankAccount
{
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            return true;
        }

        return false;
    }
}

class Encapsulation
{
    static void Main()
    {
        Employee emp = new Employee("Mahendra", 30000);

        emp.DisplayDetails();

        emp.IncreaseSalary(5000);

        emp.DisplayDetails();

        BankAccount account = new BankAccount();

        account.Deposit(10000);
        account.Withdraw(3000);

        Console.WriteLine($"Balance: {account.Balance}");
    }
}