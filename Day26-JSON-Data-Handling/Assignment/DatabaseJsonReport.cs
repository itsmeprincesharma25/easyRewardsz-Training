using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class JsonDatabaseEmployee
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Department { get; set; } = "";
    public double Salary { get; set; }
}

class DatabaseJsonReport
{
    public void Run()
    {
        List<JsonDatabaseEmployee> employees =
            new List<JsonDatabaseEmployee>
        {
            new JsonDatabaseEmployee
            {
                Id = 1,
                Name = "Prince",
                Department = "IT",
                Salary = 60000
            },
            new JsonDatabaseEmployee
            {
                Id = 2,
                Name = "Rahul",
                Department = "HR",
                Salary = 50000
            }
        };

        string json = JsonConvert.SerializeObject(
            employees, Formatting.Indented);

        Console.WriteLine(json);
    }
}