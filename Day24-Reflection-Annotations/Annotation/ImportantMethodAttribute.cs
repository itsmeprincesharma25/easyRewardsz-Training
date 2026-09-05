using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

class ImportantMethods
{
    [ImportantMethod]
    public void Login()
    {
    }

    [ImportantMethod("MEDIUM")]
    public void Search()
    {
    }
}

class ImportantMethodDemo
{
    public void Run()
    {
        foreach (MethodInfo method in typeof(ImportantMethods).GetMethods())
        {
            ImportantMethodAttribute? attribute =
                method.GetCustomAttribute<ImportantMethodAttribute>();

            if (attribute != null)
            {
                Console.WriteLine(
                    method.Name + " - " + attribute.Level);
            }
        }
    }
}