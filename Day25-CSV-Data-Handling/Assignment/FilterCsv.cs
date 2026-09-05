using System;
using System.IO;

class FilterCsv
{
    public void Run()
    {
        string[] lines = File.ReadAllLines("TestFiles/students.csv");

        Console.WriteLine("Students scoring more than 80:");

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            int marks = int.Parse(data[3]);

            if (marks > 80)
            {
                Console.WriteLine(lines[i]);
            }
        }
    }
}