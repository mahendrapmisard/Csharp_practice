using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Csharp_practice.Practice
{
    class Exercise2
    {
        private int salary;

        public int Salary
        {
            get;
        }

        public Exercise2(int salary)
        {
            this.Salary = salary;
        }
    }

    class Exercise2Program
    {
        public static void Main()
        {
            Exercise2 obj = new Exercise2(1000);
            Console.WriteLine(obj.Salary);

         }
    }
}


//1.Field = stores data.

//2.Property = provides controlled access to data.

//3. get = reads the value.

//4. set = assigns the value.

//5. value = incoming value in the setter.

//6. Private field = accessible inside its declaring class only.

//7.Public property = accessible from other classes.

//8.Inside the same class = we can use either the field or property.

//9. Using the property executes its getter/setter logic.

//10. Encapsulation = private fields +controlled access.

//11.Auto - property = compiler - generated backing field.

//12.field keyword = accesses the property's compiler-generated backing field (C# 14).