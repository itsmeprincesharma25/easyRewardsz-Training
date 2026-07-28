using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1 || k == n)
                    {
                        Console.Write("*");
                    }
                    else {
                        Console.Write(" ");
                    }
                }

            }
        }
    }
}
