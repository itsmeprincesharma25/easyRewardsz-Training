using System;
using System.Collections.Generic;
using System.IO;

class UpdateCsv
{
    public void Run()
    {
        string[] lines = File.ReadAllLines("TestFiles/employees.csv");

        List<string> updated = new List<string>();
        updated.Add(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            double salary = double.Parse(data[3]);

            if (data[2] == "IT")
            {
                salary = salary * 1.10;
            }

            data[3] = salary.ToString("0.00");
            updated.Add(string.Join(",", data));
        }

        File.WriteAllLines(
            "TestFiles/updated_employees.csv", updated);

        Console.WriteLine("Updated CSV created.");
    }
}