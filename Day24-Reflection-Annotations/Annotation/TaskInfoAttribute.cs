using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute : Attribute
{
    public string Priority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class AnnotationTaskManager
{
    [TaskInfo("HIGH", "Prince")]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed");
    }
}

class TaskInfoDemo
{
    public void Run()
    {
        MethodInfo method = typeof(AnnotationTaskManager)
            .GetMethod("CompleteTask")!;

        TaskInfoAttribute? info =
            method.GetCustomAttribute<TaskInfoAttribute>();

        Console.WriteLine("Priority: " + info?.Priority);
        Console.WriteLine("Assigned To: " + info?.AssignedTo);
    }
}