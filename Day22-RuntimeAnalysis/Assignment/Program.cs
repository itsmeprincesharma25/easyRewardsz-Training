using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Search Performance\n");

            SearchPerformance search = new SearchPerformance();

            search.Compare(1000);
            search.Compare(10000);
            search.Compare(100000);


            Console.WriteLine("Sorting Performance\n");

            SortingPerformance sorting = new SortingPerformance();

            // Keep the size small because Bubble Sort is O(N²)
            sorting.Compare(1000);


            Console.WriteLine("String Concatenation Performance\n");

            StringPerformance stringPerformance = new StringPerformance();

            stringPerformance.Compare(1000);
            stringPerformance.Compare(10000);
            stringPerformance.Compare(100000);


            Console.WriteLine("File Reading Performance\n");

            FileReadingPerformance fileReading =
                new FileReadingPerformance();

            string fileName = "test.txt";

            fileReading.Compare(fileName);


            Console.WriteLine("\nFibonacci Performance\n");

            FibonacciPerformance fibonacci =
                new FibonacciPerformance();

            // Recursive Fibonacci becomes very slow for large N
            fibonacci.Compare(30);
        }
    }
}