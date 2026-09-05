using System;
using System.Collections.Generic;

[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute
{
}

class CachedCalculator
{
    private Dictionary<int, int> cache =
        new Dictionary<int, int>();

    [CacheResult]
    public int Square(int number)
    {
        if (cache.ContainsKey(number))
        {
            Console.WriteLine("Returning cached result");
            return cache[number];
        }

        Console.WriteLine("Calculating result");

        int result = number * number;
        cache[number] = result;

        return result;
    }
}

class CacheResultDemo
{
    public void Run()
    {
        CachedCalculator calculator = new CachedCalculator();

        Console.WriteLine(calculator.Square(10));
        Console.WriteLine(calculator.Square(10));
    }
}