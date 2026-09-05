using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class SortCsv
{
    public void Run()
    {
        string[] lines = File.ReadAllLines("TestFiles/employees.csv");

        List<string[]> employees = new List<string[]>();

        for (int i = 1; i < lines.Length; i++)
        {
            employees.Add(lines[i].Split(','));
        }

        var sorted = employees
            .OrderByDescending(x => double.Parse(x[3]))
            .Take(5);

        Console.WriteLine("Top Paid Employees:");

        foreach (string[] employee in sorted)
        {
            Console.WriteLine(string.Join(" | ", employee));
        }
    }
}