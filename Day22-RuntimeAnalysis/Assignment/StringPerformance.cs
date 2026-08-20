using System;
using System.Diagnostics;
using System.Text;

namespace Assignment
{
    class StringPerformance
    {
        public void Compare(int count)
        {
            Stopwatch watch = new Stopwatch();

            // Test normal string concatenation
            watch.Start();

            string text = "";

            for (int i = 0; i < count; i++)
            {
                text += "C# ";
            }

            watch.Stop();

            long stringTime = watch.ElapsedMilliseconds;

            watch.Reset();

            // Test StringBuilder concatenation
            watch.Start();

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                builder.Append("C# ");
            }

            watch.Stop();

            long builderTime = watch.ElapsedMilliseconds;

            Console.WriteLine($"Operations: {count}");
            Console.WriteLine($"String: {stringTime} ms");
            Console.WriteLine($"StringBuilder: {builderTime} ms");
            Console.WriteLine();
        }
    }
}