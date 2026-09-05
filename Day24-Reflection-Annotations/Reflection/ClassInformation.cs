using System;
using System.Reflection;

class ClassInformation
{
    public void Run()
    {
        Console.Write("Enter class name: ");
        string? name = Console.ReadLine();

        Type? type = null;

        foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
        {
            if (t.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                type = t;
                break;
            }
        }

        if (type == null)
        {
            Console.WriteLine("Class not found");
            return;
        }

        Console.WriteLine("\nMethods:");
        foreach (MethodInfo method in type.GetMethods(
            BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.Static |
            BindingFlags.DeclaredOnly))
        {
            Console.WriteLine(method.Name);
        }

        Console.WriteLine("\nFields:");
        foreach (FieldInfo field in type.GetFields(
            BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.Static |
            BindingFlags.DeclaredOnly))
        {
            Console.WriteLine(field.Name);
        }

        Console.WriteLine("\nConstructors:");
        foreach (ConstructorInfo constructor in type.GetConstructors(
            BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Instance))
        {
            Console.WriteLine(constructor);
        }
    }
}