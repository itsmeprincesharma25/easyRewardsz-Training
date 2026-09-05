using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class JsonValidation
{
    public void Run()
    {
        string schemaJson =
            @"{
                'type': 'object',
                'properties': {
                    'name': { 'type': 'string' },
                    'age': { 'type': 'integer' }
                },
                'required': ['name', 'age']
            }";

        string json =
            @"{
                'name': 'Prince',
                'age': 22
            }";

        JSchema schema = JSchema.Parse(schemaJson);
        JObject data = JObject.Parse(json);

        bool valid = data.IsValid(schema);

        Console.WriteLine("Valid JSON: " + valid);
    }
}