using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class CsvToJson
{
    public void Run()
    {
        string[] lines =
        {
            "ID,Name,Age",
            "1,Prince,22",
            "2,Rahul,21",
            "3,Aman,23"
        };

        List<object> students =
            new List<object>();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            students.Add(new
            {
                Id = int.Parse(data[0]),
                Name = data[1],
                Age = int.Parse(data[2])
            });
        }

        string json = JsonConvert.SerializeObject(
            students, Formatting.Indented);

        Console.WriteLine(json);
    }
}