using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== DAY 25 - CSV DATA HANDLING =====");

        Console.WriteLine("\n1. Read CSV");
        new ReadCsv().Run();

        Console.WriteLine("\n2. Write CSV");
        new WriteCsv().Run();

        Console.WriteLine("\n3. Count CSV Rows");
        new CountCsvRows().Run();

        Console.WriteLine("\n4. Filter CSV");
        new FilterCsv().Run();

        Console.WriteLine("\n5. Search CSV");
        new SearchCsv().Run();

        Console.WriteLine("\n6. Update CSV");
        new UpdateCsv().Run();

        Console.WriteLine("\n7. Sort CSV");
        new SortCsv().Run();

        Console.WriteLine("\n8. Validate CSV");
        new ValidateCsv().Run();

        Console.WriteLine("\n9. CSV to Object");
        new CsvToObject().Run();

        Console.WriteLine("\n10. Merge CSV");
        new MergeCsv().Run();

        Console.WriteLine("\n11. Large CSV Reader");
        new LargeCsvReader().Run();

        Console.WriteLine("\n12. Duplicate CSV");
        new DuplicateCsv().Run();

        Console.WriteLine("\n13. Database to CSV");
        new DatabaseToCsv().Run();

        Console.WriteLine("\n14. JSON and CSV Conversion");
        new JsonCsvConverter().Run();

        Console.WriteLine("\n15. Encrypt and Decrypt CSV");
        new EncryptCsv().Run();
    }
}