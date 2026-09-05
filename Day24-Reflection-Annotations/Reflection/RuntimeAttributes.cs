using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class ReflectionAuthorAttribute : Attribute
{
    public string Name { get; }

    public ReflectionAuthorAttribute(string name)
    {
        Name = name;
    }
}

[ReflectionAuthor("Prince")]
class ReflectionBook
{
}

class RuntimeAttributes
{
    public void Run()
    {
        Type type = typeof(ReflectionBook);

        ReflectionAuthorAttribute? attribute =
            type.GetCustomAttribute<ReflectionAuthorAttribute>();

        Console.WriteLine("Author: " + attribute?.Name);
    }
}