using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Search - First Negative\n");

            int[] numbers = { 10, 25, 8, -5, 12, -9 };

            FirstNegative firstNegative = new FirstNegative();
            firstNegative.Display(numbers);


            Console.WriteLine("\nLinear Search - Search Word\n");

            string[] sentences =
            {
                "I am learning C#",
                "Today I practiced arrays",
                "I am learning algorithms"
            };

            SearchWord searchWord = new SearchWord();
            searchWord.Display(sentences, "learning");


            Console.WriteLine("\nBinary Search - Rotation Point\n");

            int[] rotatedArray = { 4, 5, 6, 7, 0, 1, 2 };

            RotationPoint rotationPoint = new RotationPoint();
            rotationPoint.Display(rotatedArray);


            Console.WriteLine("\nBinary Search - Peak Element\n");

            int[] peakArray = { 1, 3, 5, 7, 6, 4, 2 };

            PeakElement peakElement = new PeakElement();
            peakElement.Display(peakArray);


            Console.WriteLine("\nBinary Search - 2D Matrix\n");

            int[,] matrix =
            {
                { 1, 3, 5, 7 },
                { 2, 4, 6, 8 },
                { 10, 12, 14, 16 }
            };

            Search2DMatrix searchMatrix = new Search2DMatrix();
            searchMatrix.Display(matrix, 6);


            Console.WriteLine("\nBinary Search - First and Last Occurrence\n");

            int[] sortedArray = { 1, 2, 2, 2, 3, 4, 5 };

            FirstLastOccurrence occurrence = new FirstLastOccurrence();
            occurrence.Display(sortedArray, 2);


            Console.WriteLine("\nChallenge\n");

            int[] challengeArray = { 3, 4, -1, 1, 2 };

            Challenge challenge = new Challenge();

            int missing = challenge.FindMissingPositive(challengeArray);

            Console.WriteLine($"First Missing Positive: {missing}");

            int[] searchArray = { 1, 2, 3, 4, 5, 6, 7 };

            int index = challenge.BinarySearch(searchArray, 5);

            Console.WriteLine($"Target Index: {index}");
        }
    }
}