using System;
using Newtonsoft.Json.Linq;

class JsonKeysValues
{
    public void Run()
    {
        string json =
            @"{
                ""name"": ""Prince"",
                ""age"": 22,
                ""city"": ""Delhi""
            }";

        JObject data = JObject.Parse(json);

        foreach (var item in data)
        {
            Console.WriteLine(
                item.Key + " = " + item.Value);
        }
    }
}