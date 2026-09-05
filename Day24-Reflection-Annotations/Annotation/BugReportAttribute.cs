using System;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description { get; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

class BugReportDemo
{
    [BugReport("Login button not working")]
    [BugReport("Page loads slowly")]
    public void TestFeature()
    {
    }

    public void Run()
    {
        var method = typeof(BugReportDemo).GetMethod("TestFeature");

        BugReportAttribute[] reports =
            (BugReportAttribute[])Attribute.GetCustomAttributes(
                method!);

        foreach (var report in reports)
        {
            Console.WriteLine(report.Description);
        }
    }
}