using System;
using System.Diagnostics;
using System.Reflection;

class ReflectionTimingOperations
{
    public void Work()
    {
        for (int i = 0; i < 1000000; i++)
        {
        }
    }
}

class MethodExecutionTiming
{
    public void Run()
    {
        ReflectionTimingOperations obj = new ReflectionTimingOperations();

        MethodInfo? method = typeof(ReflectionTimingOperations)
            .GetMethod("Work");

        Stopwatch stopwatch = Stopwatch.StartNew();

        method?.Invoke(obj, null);

        stopwatch.Stop();

        Console.WriteLine("Execution Time: " +
            stopwatch.ElapsedTicks + " ticks");
    }
}