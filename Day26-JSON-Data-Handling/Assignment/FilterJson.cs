using System;
using Newtonsoft.Json.Linq;

class FilterJson
{
    public void Run()
    {
        string json =
            @"[
                { ""name"": ""Prince"", ""age"": 22 },
                { ""name"": ""Rahul"", ""age"": 27 },
                { ""name"": ""Aman"", ""age"": 30 }
            ]";

        JArray users = JArray.Parse(json);

        foreach (JObject user in users)
        {
            int age = (int)user["age"]!;

            if (age > 25)
            {
                Console.WriteLine(
                    user["name"] + " - " + age);
            }
        }
    }
}