using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute
{
    public string Name { get; set; } = "";
}

class JsonAttributeUser
{
    [JsonField(Name = "user_name")]
    public string Name = "Prince";

    [JsonField(Name = "user_age")]
    public int Age = 22;
}

class JsonFieldDemo
{
    public void Run()
    {
        JsonAttributeUser user = new JsonAttributeUser();

        Console.Write("{ ");

        FieldInfo[] fields = typeof(JsonAttributeUser).GetFields();

        for (int i = 0; i < fields.Length; i++)
        {
            JsonFieldAttribute? attribute =
                fields[i].GetCustomAttribute<JsonFieldAttribute>();

            string name = attribute?.Name ?? fields[i].Name;

            Console.Write(
                "\"" + name + "\": \"" +
                fields[i].GetValue(user) + "\"");

            if (i < fields.Length - 1)
                Console.Write(", ");
        }

        Console.WriteLine(" }");
    }
}