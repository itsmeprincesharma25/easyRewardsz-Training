using System;

namespace Assignment
{
    class FinallyDemo
    {
        public void Divide()
        {
            try
            {
                Console.Write("Enter first number: ");
                int first = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int second = int.Parse(Console.ReadLine());

                int result = first / second;

                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid numbers");
            }
            finally
            {
                // This always runs after try/catch
                Console.WriteLine("Operation completed");
            }
        }
    }
}