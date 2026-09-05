using System;
using Newtonsoft.Json.Linq;

class MergeJson
{
    public void Run()
    {
        JObject first = JObject.Parse(
            @"{ ""name"": ""Prince"", ""age"": 22 }");

        JObject second = JObject.Parse(
            @"{ ""city"": ""Delhi"", ""course"": ""C#"" }");

        first.Merge(second);

        Console.WriteLine(
            first.ToString());
    }
}