using System;

namespace VariablesDemo
{
    class LoopsDemo
    {
        static void Main(string[] args)
        {
            // For loop
            Console.WriteLine("For Loop:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteration {i}");
            }

            // While loop
            Console.WriteLine("\nWhile Loop:");
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine($"Count is {count}");
                count++;
            }

            // Do-While loop
            Console.WriteLine("\nDo-While Loop:");
            int num = 0;
            do
            {
                Console.WriteLine($"Number is {num}");
                num++;
            } while (num < 5);

            // Foreach loop
            Console.WriteLine("\nForeach Loop:");
            string[] fruits = { "Apple", "Banana", "Cherry" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}