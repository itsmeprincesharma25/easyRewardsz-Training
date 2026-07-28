using System;

namespace OperatorsDemo
{
    public static class PrecedenceDemo
    {
        public static void Run()
        {
            Console.WriteLine("--- Operator Precedence & Associativity ---\n");

            // 1. Multiplication (*) runs before Addition (+)
            int result1 = 10 + 5 * 2; // 10 + 10 = 20
            Console.WriteLine($"10 + 5 * 2 = {result1}");

            // Parentheses override priority
            int result2 = (10 + 5) * 2; // 15 * 2 = 30
            Console.WriteLine($"(10 + 5) * 2 = {result2}\n");

            // 2. Division and Multiplication have same priority, evaluates Left to Right
            int result3 = 100 / 10 * 2; // (100 / 10) * 2 = 20
            Console.WriteLine($"100 / 10 * 2 = {result3}\n");

            // 3. AND (&&) runs before OR (||)
            bool check1 = true || false && false;   // true || (false) = true
            bool check2 = (true || false) && false; // (true) && false = false
            Console.WriteLine($"true || false && false = {check1}");
            Console.WriteLine($"(true || false) && false = {check2}\n");

            // 4. Assignment evaluates Right to Left
            int x, y, z;
            x = y = z = 50; // Assigns 50 to z, then y, then x
            Console.WriteLine($"x = {x}, y = {y}, z = {z}");
        }
    }
}