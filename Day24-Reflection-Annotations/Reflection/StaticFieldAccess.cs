using System;
using System.Reflection;

class ReflectionConfiguration
{
    private static string API_KEY = "OLD_KEY";
}

class StaticFieldAccess
{
    public void Run()
    {
        FieldInfo? field = typeof(ReflectionConfiguration).GetField(
            "API_KEY",
            BindingFlags.NonPublic | BindingFlags.Static);

        field?.SetValue(null, "NEW_KEY");

        Console.WriteLine("API Key: " + field?.GetValue(null));
    }
}