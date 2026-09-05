using System;
using System.IO;

class ReadCsv
{
    public void Run()
    {
        string file = "TestFiles/students.csv";

        if (!File.Exists(file))
        {
            File.WriteAllText(file,
                "ID,Name,Age,Marks\n" +
                "1,Prince,22,85\n" +
                "2,Rahul,21,78\n" +
                "3,Aman,23,91");
        }

        string[] lines = File.ReadAllLines(file);

        Console.WriteLine("Student Records:");

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            Console.WriteLine(
                $"ID: {data[0]}, Name: {data[1]}, Age: {data[2]}, Marks: {data[3]}");
        }
    }
}