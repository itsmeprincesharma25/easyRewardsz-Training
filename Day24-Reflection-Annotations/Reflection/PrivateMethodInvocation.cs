using System;
using System.Reflection;

class ReflectionCalculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class PrivateMethodInvocation
{
    public void Run()
    {
        ReflectionCalculator calculator = new ReflectionCalculator();

        MethodInfo? method = typeof(ReflectionCalculator).GetMethod(
            "Multiply",
            BindingFlags.NonPublic | BindingFlags.Instance);

        object? result = method?.Invoke(calculator, new object[] { 5, 6 });

        Console.WriteLine("Result: " + result);
    }
}