using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== DAY 24 - ANNOTATIONS =====");

        Console.WriteLine("\n1. Method Overriding");
        new MethodOverriding().Run();

        Console.WriteLine("\n2. Obsolete Attribute");
        new ObsoleteDemo().Run();

        Console.WriteLine("\n3. Warning Suppression");
        new WarningSuppression().Run();

        Console.WriteLine("\n4. TaskInfo Attribute");
        new TaskInfoDemo().Run();

        Console.WriteLine("\n5. Repeatable BugReport");
        new BugReportDemo().Run();

        Console.WriteLine("\n6. ImportantMethod Attribute");
        new ImportantMethodDemo().Run();

        Console.WriteLine("\n7. Todo Attribute");
        new TodoDemo().Run();

        Console.WriteLine("\n8. LogExecutionTime Attribute");
        new LogExecutionTimeDemo().Run();

        Console.WriteLine("\n9. MaxLength Attribute");
        new MaxLengthDemo().Run();

        Console.WriteLine("\n10. RoleAllowed Attribute");
        new RoleAllowedDemo().Run();

        Console.WriteLine("\n11. JsonField Attribute");
        new JsonFieldDemo().Run();

        Console.WriteLine("\n12. CacheResult Attribute");
        new CacheResultDemo().Run();
    }
}