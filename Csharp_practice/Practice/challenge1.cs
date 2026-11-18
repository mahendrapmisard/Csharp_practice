using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.Practice
{
     class challenge1
    {
        public int id { get; set; }
        public string name { get; set; }

        public void displaydetails()
        {
            Console.WriteLine(id +" "+ name);
        }

    }

    class student
    {
        public string name{ get; set; }
        public int id { get; set; }

        public  student()
        {
            Console.WriteLine("default constructor");
        }
        public student(int id, string name)
        {
            Console.WriteLine(name + " " + id);
        } 
    }

    class Inher
    {
        public static void main()
        {
            student obj = new student();
            student obj2 = new student(1, "mahendra");
        }
    }


    class employee
    {
       public int EmployeeId;
        public string EmployeeName;
        public double Salary;
        public string Department;

        public void displaydetails(department department)
        {
            Console.WriteLine(department.departmentid);
            Console.WriteLine(department.departmentname);
            Console.WriteLine(EmployeeName);
            Console.WriteLine(EmployeeId);
        
        }

        public double calculatesalary(department department)
        {
            return (Salary + department.depbonus);
        }

    }

    class department
    {
       public  int departmentid;
        public string departmentname;

        public double depbonus;

    }

    class main
        {
        public static void Main()
        {
            //challenge1 obj = new challenge1();
            //obj.id = 10;
            //obj.name = "mahendra";

            //obj.displaydetails();

            //student obj1 = new student();

            //student obj2 = new student(1, "mahendra");

            department depobj = new department();
            depobj.departmentid = 11;
            depobj.departmentname = "software";
            depobj.depbonus = 200;

            employee empobj = new employee();
            empobj.EmployeeId = 90;
            empobj.EmployeeName = "mahendra";
            empobj.Salary = 10000.0 ;
            empobj.Department = "software";
            empobj.calculatesalary(depobj);

            empobj.displaydetails(depobj);
        }
        }
}
