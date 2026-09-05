using System;
using System.IO;

class LargeCsvReader
{
    public void Run()
    {
        string file = "TestFiles/large.csv";

        if (!File.Exists(file))
        {
            using StreamWriter writer = new StreamWriter(file);

            writer.WriteLine("ID,Name");

            for (int i = 1; i <= 250; i++)
            {
                writer.WriteLine($"{i},Student{i}");
            }
        }

        int count = 0;

        using StreamReader reader = new StreamReader(file);

        string? line;

        while ((line = reader.ReadLine()) != null)
        {
            count++;

            if (count % 100 == 0)
            {
                Console.WriteLine(
                    $"Records processed: {count}");
            }
        }

        Console.WriteLine("Total records processed: " + (count - 1));
    }
}