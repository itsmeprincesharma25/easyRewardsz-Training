using System;
using System.Collections.Generic;
using System.IO;

class DuplicateCsv
{
    public void Run()
    {
        string file = "TestFiles/duplicates.csv";

        if (!File.Exists(file))
        {
            File.WriteAllText(file,
                "ID,Name\n" +
                "1,Prince\n" +
                "2,Rahul\n" +
                "1,Prince\n" +
                "3,Aman\n" +
                "2,Rahul");
        }

        string[] lines = File.ReadAllLines(file);

        HashSet<string> ids = new HashSet<string>();
        HashSet<string> duplicates = new HashSet<string>();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            if (!ids.Add(data[0]))
            {
                duplicates.Add(lines[i]);
            }
        }

        Console.WriteLine("Duplicate Records:");

        foreach (string record in duplicates)
        {
            Console.WriteLine(record);
        }
    }
}