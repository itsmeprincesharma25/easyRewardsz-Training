using System;
using System.IO;
using System.Text.RegularExpressions;

class ValidateCsv
{
    public void Run()
    {
        string file = "TestFiles/contacts.csv";

        if (!File.Exists(file))
        {
            File.WriteAllText(file,
                "ID,Name,Email,Phone\n" +
                "1,Prince,prince@gmail.com,9876543210\n" +
                "2,Rahul,rahulgmail.com,987654321\n" +
                "3,Aman,aman@gmail.com,9876543211");
        }

        string[] lines = File.ReadAllLines(file);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            bool validEmail =
                Regex.IsMatch(data[2],
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            bool validPhone =
                Regex.IsMatch(data[3], @"^\d{10}$");

            if (!validEmail)
            {
                Console.WriteLine(
                    $"Invalid email in row {i + 1}");
            }

            if (!validPhone)
            {
                Console.WriteLine(
                    $"Invalid phone in row {i + 1}");
            }
        }
    }
}