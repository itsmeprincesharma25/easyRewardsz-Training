using System;
using System.Reflection;

class ReflectionUser
{
    public int Id = 1;
    public string Name = "Prince";
}

class JsonRepresentation
{
    public void Run()
    {
        ReflectionUser user = new ReflectionUser();

        FieldInfo[] fields = typeof(ReflectionUser).GetFields();

        Console.Write("{ ");

        for (int i = 0; i < fields.Length; i++)
        {
            Console.Write("\"" + fields[i].Name + "\": ");
            Console.Write("\"" + fields[i].GetValue(user) + "\"");

            if (i < fields.Length - 1)
                Console.Write(", ");
        }

        Console.WriteLine(" }");
    }
}