using System;
using System.Diagnostics;

namespace Assignment
{
    class FibonacciPerformance
    {
        public long FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;

            return FibonacciRecursive(n - 1) +
                   FibonacciRecursive(n - 2);
        }

        public long FibonacciIterative(int n)
        {
            if (n <= 1)
                return n;

            long a = 0;
            long b = 1;

            // Calculate Fibonacci values using a loop
            for (int i = 2; i <= n; i++)
            {
                long sum = a + b;
                a = b;
                b = sum;
            }

            return b;
        }

        public void Compare(int n)
        {
            Stopwatch watch = new Stopwatch();

            // Measure recursive Fibonacci
            watch.Start();
            long recursiveResult = FibonacciRecursive(n);
            watch.Stop();

            long recursiveTime = watch.ElapsedTicks;

            watch.Reset();

            // Measure iterative Fibonacci
            watch.Start();
            long iterativeResult = FibonacciIterative(n);
            watch.Stop();

            long iterativeTime = watch.ElapsedTicks;

            Console.WriteLine($"N: {n}");
            Console.WriteLine($"Recursive Result: {recursiveResult}");
            Console.WriteLine($"Recursive Time: {recursiveTime} ticks");
            Console.WriteLine($"Iterative Result: {iterativeResult}");
            Console.WriteLine($"Iterative Time: {iterativeTime} ticks");
            Console.WriteLine();
        }
    }
}