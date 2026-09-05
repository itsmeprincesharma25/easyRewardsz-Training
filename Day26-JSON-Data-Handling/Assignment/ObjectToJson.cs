using System;
using Newtonsoft.Json;

class JsonCar
{
    public string Brand { get; set; } = "";
    public string Model { get; set; } = "";
    public int Year { get; set; }
}

class ObjectToJson
{
    public void Run()
    {
        JsonCar car = new JsonCar
        {
            Brand = "Toyota",
            Model = "Camry",
            Year = 2025
        };

        string json = JsonConvert.SerializeObject(
            car, Formatting.Indented);

        Console.WriteLine(json);
    }
}