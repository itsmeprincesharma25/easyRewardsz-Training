using System;
using Newtonsoft.Json;

class BasicJson
{
    public void Run()
    {
        var student = new
        {
            name = "Prince",
            age = 22,
            subjects = new[] { "C#", "SQL", "DSA" }
        };

        string json = JsonConvert.SerializeObject(
            student, Formatting.Indented);

        Console.WriteLine(json);
    }
}