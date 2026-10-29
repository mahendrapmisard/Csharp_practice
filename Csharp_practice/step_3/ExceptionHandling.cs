using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_practice.step_3
{

    class EXHandling
    {
        public static void Main()
        {
            DivideNumbers();
            ConvertToNumber();
            AccessArray();
            AccessNullObject();
            HandleMultipleExceptions();
            FinallyExample();

            Console.WriteLine("\nProgram completed successfully");
        }

        static void DivideNumbers()
        {
            try
            {
                int a = 10;
                int b = 0;
                int result = a / b;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Division method continues");
        }

        static void ConvertToNumber()
        {
            try
            {
                string input = "hello";
                int number = int.Parse(input);

                Console.WriteLine(number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid number format");
                Console.WriteLine(ex.Message);
            }
        }

        static void AccessArray()
        {
            try
            {
                int[] numbers = { 10, 20, 30 };

                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array index does not exist");
                Console.WriteLine(ex.Message);
            }
        }

        static void AccessNullObject()
        {
            try
            {
                string name = null;
                Console.WriteLine(name.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Cannot access a member through null");
                Console.WriteLine(ex.Message);
            }
        }

        static void HandleMultipleExceptions()
        {
            try
            {
                int[] numbers = { 10, 20 };
                int divisor = 0;

                Console.WriteLine(numbers[5] / divisor);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Array index error");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some other error occurred");
                Console.WriteLine(ex.Message);
            }
        }

        static void FinallyExample()
        {
            try
            {
                int result = 10 / int.Parse("0");
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero handled");
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
    }
}
