using System;
using System.IO;

class CountCsvRows
{
    public void Run()
    {
        string file = "TestFiles/students.csv";

        string[] lines = File.ReadAllLines(file);

        Console.WriteLine("Total Records: " + (lines.Length - 1));
    }
}