using System;
using System.Collections.Generic;
using System.IO;

class CsvStudent
{
    public int Id;
    public string Name = "";
    public int Age;
    public int Marks;

    public override string ToString()
    {
        return $"{Id} | {Name} | {Age} | {Marks}";
    }
}

class CsvToObject
{
    public void Run()
    {
        string[] lines = File.ReadAllLines(
            "TestFiles/students.csv");

        List<CsvStudent> students = new List<CsvStudent>();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            students.Add(new CsvStudent
            {
                Id = int.Parse(data[0]),
                Name = data[1],
                Age = int.Parse(data[2]),
                Marks = int.Parse(data[3])
            });
        }

        foreach (CsvStudent student in students)
        {
            Console.WriteLine(student);
        }
    }
}