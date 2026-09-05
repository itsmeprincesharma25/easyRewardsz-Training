using System;
using System.IO;

class WriteCsv
{
    public void Run()
    {
        string file = "TestFiles/employees.csv";

        string[] employees =
        {
            "ID,Name,Department,Salary",
            "1,Prince,IT,60000",
            "2,Rahul,HR,50000",
            "3,Aman,IT,70000",
            "4,Neha,Finance,65000",
            "5,Riya,IT,75000"
        };

        File.WriteAllLines(file, employees);

        Console.WriteLine("Employee CSV created.");
    }
}