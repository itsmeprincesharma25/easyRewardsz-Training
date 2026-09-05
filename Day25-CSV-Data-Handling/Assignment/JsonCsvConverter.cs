using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class JsonStudent
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public int Marks { get; set; }
}

class JsonCsvConverter
{
    public void Run()
    {
        string jsonFile = "TestFiles/students.json";

        if (!File.Exists(jsonFile))
        {
            List<JsonStudent> students = new List<JsonStudent>
            {
                new JsonStudent
                {
                    Id = 1,
                    Name = "Prince",
                    Age = 22,
                    Marks = 85
                },
                new JsonStudent
                {
                    Id = 2,
                    Name = "Rahul",
                    Age = 21,
                    Marks = 78
                }
            };

            string json = JsonSerializer.Serialize(
                students,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(jsonFile, json);
        }

        string jsonText = File.ReadAllText(jsonFile);

        List<JsonStudent>? data =
            JsonSerializer.Deserialize<List<JsonStudent>>(jsonText);

        List<string> csv = new List<string>
        {
            "ID,Name,Age,Marks"
        };

        if (data != null)
        {
            foreach (JsonStudent student in data)
            {
                csv.Add(
                    $"{student.Id},{student.Name},{student.Age},{student.Marks}");
            }
        }

        string csvFile = "TestFiles/json_to_csv.csv";
        File.WriteAllLines(csvFile, csv);

        Console.WriteLine("JSON converted to CSV.");

        List<JsonStudent> backToJson =
            new List<JsonStudent>();

        string[] lines = File.ReadAllLines(csvFile);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');

            backToJson.Add(new JsonStudent
            {
                Id = int.Parse(parts[0]),
                Name = parts[1],
                Age = int.Parse(parts[2]),
                Marks = int.Parse(parts[3])
            });
        }

        string result = JsonSerializer.Serialize(
            backToJson,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        File.WriteAllText(
            "TestFiles/csv_to_json.json", result);

        Console.WriteLine("CSV converted back to JSON.");
    }
}