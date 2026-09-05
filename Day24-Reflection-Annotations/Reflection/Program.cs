using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== DAY 24 - REFLECTION =====");

        Console.WriteLine("\n1. Class Information");
        new ClassInformation().Run();

        Console.WriteLine("\n2. Private Field Access");
        new PrivateFieldAccess().Run();

        Console.WriteLine("\n3. Private Method Invocation");
        new PrivateMethodInvocation().Run();

        Console.WriteLine("\n4. Dynamic Object Creation");
        new DynamicObjectCreation().Run();

        Console.WriteLine("\n5. Dynamic Method Invocation");
        new DynamicMethodInvocation().Run();

        Console.WriteLine("\n6. Runtime Attributes");
        new RuntimeAttributes().Run();

        Console.WriteLine("\n7. Static Field Access");
        new StaticFieldAccess().Run();

        Console.WriteLine("\n8. Custom Object Mapper");
        new CustomObjectMapper().Run();

        Console.WriteLine("\n9. JSON Representation");
        new JsonRepresentation().Run();

        Console.WriteLine("\n10. Logging Proxy");
        new LoggingProxy().Run();

        Console.WriteLine("\n11. Dependency Injection");
        new DependencyInjection().Run();

        Console.WriteLine("\n12. Method Execution Timing");
        new MethodExecutionTiming().Run();
    }
}