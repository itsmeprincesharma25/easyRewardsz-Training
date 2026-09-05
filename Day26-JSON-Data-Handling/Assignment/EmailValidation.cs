using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

class EmailValidation
{
    public void Run()
    {
        string json =
            @"{
                ""name"": ""Prince"",
                ""email"": ""prince@gmail.com""
            }";

        JObject data = JObject.Parse(json);

        string email = data["email"]!.ToString();

        string pattern =
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        bool valid = Regex.IsMatch(email, pattern);

        Console.WriteLine("Email valid: " + valid);
    }
}