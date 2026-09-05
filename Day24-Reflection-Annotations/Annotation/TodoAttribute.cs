using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(
        string task,
        string assignedTo,
        string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class TodoTasks
{
    [Todo("Add login validation", "Prince")]
    [Todo("Add logging", "Rahul", "HIGH")]
    public void Feature()
    {
    }
}

class TodoDemo
{
    public void Run()
    {
        MethodInfo method = typeof(TodoTasks).GetMethod("Feature")!;

        TodoAttribute[] tasks =
            (TodoAttribute[])Attribute.GetCustomAttributes(method);

        foreach (TodoAttribute task in tasks)
        {
            Console.WriteLine(
                task.Task + " | " +
                task.AssignedTo + " | " +
                task.Priority);
        }
    }
}