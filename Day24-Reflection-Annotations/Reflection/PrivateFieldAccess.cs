using System;
using System.Reflection;

class ReflectionPerson
{
    private int age = 20;
}

class PrivateFieldAccess
{
    public void Run()
    {
        ReflectionPerson person = new ReflectionPerson();

        FieldInfo? field = typeof(ReflectionPerson).GetField(
            "age",
            BindingFlags.NonPublic | BindingFlags.Instance);

        field?.SetValue(person, 25);

        Console.WriteLine("Private age: " + field?.GetValue(person));
    }
}