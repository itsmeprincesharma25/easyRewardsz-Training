using System;
using System.Collections.Generic;
using System.IO;

class DatabaseEmployee
{
    public int Id;
    public string Name = "";
    public string Department = "";
    public double Salary;
}

class DatabaseToCsv
{
    public void Run()
    {
        List<DatabaseEmployee> employees =
            new List<DatabaseEmployee>
        {
            new DatabaseEmployee
            {
                Id = 1,
                Name = "Prince",
                Department = "IT",
                Salary = 60000
            },
            new DatabaseEmployee
            {
                Id = 2,
                Name = "Rahul",
                Department = "HR",
                Salary = 50000
            }
        };

        List<string> lines = new List<string>();

        lines.Add("Employee ID,Name,Department,Salary");

        foreach (DatabaseEmployee employee in employees)
        {
            lines.Add(
                $"{employee.Id},{employee.Name},{employee.Department},{employee.Salary}");
        }

        File.WriteAllLines(
            "TestFiles/database_report.csv", lines);

        Console.WriteLine("Database report created.");
    }
}