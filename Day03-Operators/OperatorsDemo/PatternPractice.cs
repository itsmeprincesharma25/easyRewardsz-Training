using System;

namespace OperatorsDemo
{
    public static class PatternPractice
    {
        // 1. Right-Angled Triangle
        public static void PrintRightTriangle(int rows = 5)
        {
            Console.WriteLine("--- 1. Right-Angled Triangle ---");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 2. Inverted Right-Angled Triangle
        public static void PrintInvertedTriangle(int rows = 5)
        {
            Console.WriteLine("--- 2. Inverted Right-Angled Triangle ---");
            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 3. Left-Aligned Right Triangle
        public static void PrintLeftAlignedTriangle(int rows = 5)
        {
            Console.WriteLine("--- 3. Left-Aligned Right Triangle ---");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 4. Full Pyramid
        public static void PrintPyramid(int rows = 5)
        {
            Console.WriteLine("--- 4. Full Pyramid ---");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 5. Inverted Pyramid
        public static void PrintInvertedPyramid(int rows = 5)
        {
            Console.WriteLine("--- 5. Inverted Pyramid ---");
            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 6. Full Diamond
        public static void PrintDiamond(int rows = 5)
        {
            Console.WriteLine("--- 6. Full Diamond ---");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++) Console.Write(" ");
                for (int k = 1; k <= (2 * i - 1); k++) Console.Write("*");
                Console.WriteLine();
            }
            for (int i = rows - 1; i >= 1; i--)
            {
                for (int j = 1; j <= rows - i; j++) Console.Write(" ");
                for (int k = 1; k <= (2 * i - 1); k++) Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 7. Half Diamond
        public static void PrintHalfDiamond(int rows = 5)
        {
            Console.WriteLine("--- 7. Half Diamond ---");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++) Console.Write("* ");
                Console.WriteLine();
            }
            for (int i = rows - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++) Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 8. Sequential Number Triangle
        public static void PrintSequentialNumberTriangle(int rows = 5)
        {
            Console.WriteLine("--- 8. Sequential Number Triangle ---");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 9. Same-Number Row Triangle
        public static void PrintSameNumberTriangle(int rows = 5)
        {
            Console.WriteLine("--- 9. Same-Number Row Triangle ---");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 10. Floyd's Triangle
        public static void PrintFloydsTriangle(int rows = 5)
        {
            Console.WriteLine("--- 10. Floyd's Triangle ---");
            int number = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{number} ");
                    number++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 11. Binary Triangle
        public static void PrintBinaryTriangle(int rows = 5)
        {
            Console.WriteLine("--- 11. Binary Triangle ---");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((i + j) % 2 == 0 ? "1 " : "0 ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 12. Alphabet Triangle
        public static void PrintAlphabetTriangle(int rows = 5)
        {
            Console.WriteLine("--- 12. Alphabet Triangle ---");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    char ch = (char)('A' + j - 1);
                    Console.Write($"{ch} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        
        }
    }
}