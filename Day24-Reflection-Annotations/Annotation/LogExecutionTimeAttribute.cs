using System;
using System.Diagnostics;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute
{
}

class ExecutionTimeMethods
{
    [LogExecutionTime]
    public void FirstMethod()
    {
        for (int i = 0; i < 100000; i++)
        {
        }
    }

    [LogExecutionTime]
    public void SecondMethod()
    {
        for (int i = 0; i < 500000; i++)
        {
        }
    }
}

class LogExecutionTimeDemo
{
    public void Run()
    {
        ExecutionTimeMethods obj = new ExecutionTimeMethods();

        Stopwatch watch = new Stopwatch();

        watch.Start();
        obj.FirstMethod();
        watch.Stop();

        Console.WriteLine("First Method: " +
            watch.ElapsedTicks + " ticks");

        watch.Restart();
        obj.SecondMethod();
        watch.Stop();

        Console.WriteLine("Second Method: " +
            watch.ElapsedTicks + " ticks");
    }
}