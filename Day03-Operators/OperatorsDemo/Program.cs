using System;

namespace OperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     C# OPERATOR PRECEDENCE      ");
            
            PrecedenceDemo.Run();
            /*
                Priority Order:
                Parentheses () -> Math (*, /, % then +, -) -> Comparison (>, <) -> Logical (&& then ||) -> Assignment (=)

                Associativity:
                Math runs Left-to-Right | Assignment runs Right-to-Left
            */
            

            Console.WriteLine("   EASYREWARDS TRAINING: COMPLETE PATTERN SUITE   ");
            

            // Group 1: Basic
            PatternPractice.PrintRightTriangle();
            PatternPractice.PrintInvertedTriangle();
            PatternPractice.PrintLeftAlignedTriangle();

            // Group 2: Pyramids & Diamonds
            PatternPractice.PrintPyramid();
            PatternPractice.PrintInvertedPyramid();
            PatternPractice.PrintDiamond();
            PatternPractice.PrintHalfDiamond();

            // Group 3: Numbers & Characters
            PatternPractice.PrintSequentialNumberTriangle();
            PatternPractice.PrintSameNumberTriangle();
            PatternPractice.PrintFloydsTriangle();
            PatternPractice.PrintBinaryTriangle();
            PatternPractice.PrintAlphabetTriangle();


        }
    }
}