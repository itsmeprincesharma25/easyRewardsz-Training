using System;
using Newtonsoft.Json.Linq;

class ReadJsonFields
{
    public void Run()
    {
        string json =
            @"{
                ""name"": ""Prince"",
                ""email"": ""prince@gmail.com"",
                ""age"": 22
            }";

        JObject data = JObject.Parse(json);

        Console.WriteLine("Name: " + data["name"]);
        Console.WriteLine("Email: " + data["email"]);
    }
}