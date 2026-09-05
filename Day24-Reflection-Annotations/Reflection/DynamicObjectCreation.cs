using System;

class ReflectionStudent
{
    public string Name { get; set; }

    public ReflectionStudent()
    {
        Name = "Prince";
    }
}

class DynamicObjectCreation
{
    public void Run()
    {
        Type type = typeof(ReflectionStudent);

        object? obj = Activator.CreateInstance(type);

        ReflectionStudent? student = obj as ReflectionStudent;

        Console.WriteLine("Student: " + student?.Name);
    }
}