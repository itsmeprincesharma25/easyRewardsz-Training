using System;

class SearchCsv
{
    public void Run()
    {
        string[] lines = System.IO.File.ReadAllLines(
            "TestFiles/employees.csv");

        string searchName = "Aman";

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            if (data[1].Equals(searchName,
                StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Department: " + data[2]);
                Console.WriteLine("Salary: " + data[3]);
                return;
            }
        }

        Console.WriteLine("Employee not found.");
    }
}