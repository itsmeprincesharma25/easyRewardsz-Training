using System;
using System.Collections.Generic;
using System.IO;

class MergeCsv
{
    public void Run()
    {
        string file1 = "TestFiles/students1.csv";
        string file2 = "TestFiles/students2.csv";

        if (!File.Exists(file1))
        {
            File.WriteAllText(file1,
                "ID,Name,Age\n" +
                "1,Prince,22\n" +
                "2,Rahul,21\n" +
                "3,Aman,23");
        }

        if (!File.Exists(file2))
        {
            File.WriteAllText(file2,
                "ID,Marks,Grade\n" +
                "1,85,A\n" +
                "2,78,B\n" +
                "3,91,A+");
        }

        Dictionary<string, string[]> first =
            new Dictionary<string, string[]>();

        string[] lines1 = File.ReadAllLines(file1);

        for (int i = 1; i < lines1.Length; i++)
        {
            string[] data = lines1[i].Split(',');
            first[data[0]] = data;
        }

        List<string> result = new List<string>();
        result.Add("ID,Name,Age,Marks,Grade");

        string[] lines2 = File.ReadAllLines(file2);

        for (int i = 1; i < lines2.Length; i++)
        {
            string[] data = lines2[i].Split(',');

            if (first.ContainsKey(data[0]))
            {
                string[] student = first[data[0]];

                result.Add(
                    $"{student[0]},{student[1]},{student[2]},{data[1]},{data[2]}");
            }
        }

        File.WriteAllLines(
            "TestFiles/merged_students.csv", result);

        Console.WriteLine("CSV files merged.");
    }
}