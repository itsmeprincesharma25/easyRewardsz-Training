using System;
using System.Reflection;

class ReflectionMathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

class DynamicMethodInvocation
{
    public void Run()
    {
        ReflectionMathOperations math = new ReflectionMathOperations();

        Console.Write("Enter operation (Add/Subtract/Multiply): ");
        string? operation = Console.ReadLine();

        MethodInfo? method = typeof(ReflectionMathOperations)
            .GetMethod(operation ?? "");

        if (method == null)
        {
            Console.WriteLine("Invalid operation");
            return;
        }

        object? result = method.Invoke(math, new object[] { 10, 5 });

        Console.WriteLine("Result: " + result);
    }
}