using System;
using System.Collections.Generic;
using System.Reflection;

class ReflectionProduct
{
    public int Id;
    public string Name = "";
    public double Price;
}

class CustomObjectMapper
{
    public T ToObject<T>(Dictionary<string, object> properties)
        where T : new()
    {
        T obj = new T();

        foreach (var item in properties)
        {
            FieldInfo? field = typeof(T).GetField(item.Key);

            if (field != null)
            {
                field.SetValue(obj, item.Value);
            }
        }

        return obj;
    }

    public void Run()
    {
        Dictionary<string, object> data = new Dictionary<string, object>
        {
            { "Id", 101 },
            { "Name", "Laptop" },
            { "Price", 55000.0 }
        };

        ReflectionProduct product = ToObject<ReflectionProduct>(data);

        Console.WriteLine(product.Id);
        Console.WriteLine(product.Name);
        Console.WriteLine(product.Price);
    }
}