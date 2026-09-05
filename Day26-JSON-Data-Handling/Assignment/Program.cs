using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("DAY 26 - JSON & DATA HANDLING");
        Console.WriteLine("\n1. Basic JSON");
        new BasicJson().Run();

        Console.WriteLine("\n2. Object to JSON");
        new ObjectToJson().Run();

        Console.WriteLine("\n3. Read Specific JSON Fields");
        new ReadJsonFields().Run();

        Console.WriteLine("\n4. Merge JSON");
        new MergeJson().Run();

        Console.WriteLine("\n5. JSON Validation");
        new JsonValidation().Run();

        Console.WriteLine("\n6. List to JSON");
        new ListToJson().Run();

        Console.WriteLine("\n7. Filter JSON");
        new FilterJson().Run();

        Console.WriteLine("\n8. JSON Keys and Values");
        new JsonKeysValues().Run();

        Console.WriteLine("\n9. Email Validation");
        new EmailValidation().Run();

        Console.WriteLine("\n10. JSON to XML");
        new JsonToXml().Run();

        Console.WriteLine("\n11. CSV to JSON");
        new CsvToJson().Run();

        Console.WriteLine("\n12. Database JSON Report");
        new DatabaseJsonReport().Run();

        Console.WriteLine("\n13. IPL Censorship Analyzer");
        new IplCensorshipAnalyzer().Run();
    }
}