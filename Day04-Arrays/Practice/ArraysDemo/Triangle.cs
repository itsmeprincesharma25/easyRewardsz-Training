using System;

namespace MyNamespace
{
    class Triangle
    {
        public static void checkTriangle()
        {
            int a = int.Parse(Console.ReadLine()!);
            int b = int.Parse(Console.ReadLine()!);
            int c = int.Parse(Console.ReadLine()!);
            int sum = a + b + c;
            Console.WriteLine($"The sum of inner angles of Triangle is : {sum}");
            if (sum == 180) Console.WriteLine("Yes it is a Triangle.");
            else Console.WriteLine("No it not a Triangle.");
        }
    }
}