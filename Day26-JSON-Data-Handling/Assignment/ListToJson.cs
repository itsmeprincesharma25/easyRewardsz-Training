using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class JsonEmployee
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}

class ListToJson
{
    public void Run()
    {
        List<JsonEmployee> employees =
            new List<JsonEmployee>
        {
            new JsonEmployee { Id = 1, Name = "Prince" },
            new JsonEmployee { Id = 2, Name = "Rahul" },
            new JsonEmployee { Id = 3, Name = "Aman" }
        };

        string json = JsonConvert.SerializeObject(
            employees, Formatting.Indented);

        Console.WriteLine(json);
    }
}