using System;
using System.Diagnostics;

namespace Assignment
{
    class SearchPerformance
    {
        public int LinearSearch(int[] numbers, int target)
        {
            // Check every element until the target is found
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                    return i;
            }

            return -1;
        }

        public int BinarySearch(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            // Search by repeatedly dividing the sorted array
            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (numbers[middle] == target)
                    return middle;

                if (numbers[middle] < target)
                    left = middle + 1;
                else
                    right = middle - 1;
            }

            return -1;
        }

        public void Compare(int size)
        {
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = i + 1;
            }

            int target = size;

            Stopwatch watch = new Stopwatch();

            watch.Start();
            LinearSearch(numbers, target);
            watch.Stop();

            long linearTime = watch.ElapsedTicks;

            watch.Reset();

            watch.Start();
            BinarySearch(numbers, target);
            watch.Stop();

            long binaryTime = watch.ElapsedTicks;

            Console.WriteLine($"Dataset Size: {size}");
            Console.WriteLine($"Linear Search: {linearTime} ticks");
            Console.WriteLine($"Binary Search: {binaryTime} ticks");
            Console.WriteLine();
        }
    }
}