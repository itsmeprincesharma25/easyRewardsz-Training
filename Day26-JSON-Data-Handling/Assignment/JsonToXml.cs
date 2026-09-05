using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class JsonToXml
{
    public void Run()
    {
        string json =
            @"{
                ""name"": ""Prince"",
                ""age"": 22
            }";

        JObject data = JObject.Parse(json);

        string xml = JsonConvert.DeserializeXNode(
            data.ToString(), "Student")!.ToString();

        Console.WriteLine(xml);
    }
}