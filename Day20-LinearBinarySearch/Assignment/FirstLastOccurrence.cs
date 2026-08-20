using System;

namespace Assignment
{
    class FirstLastOccurrence
    {
        public int FindFirst(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            int result = -1;

            // Search for the first occurrence
            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (numbers[middle] == target)
                {
                    result = middle;
                    right = middle - 1;
                }
                else if (numbers[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return result;
        }

        public int FindLast(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            int result = -1;

            // Search for the last occurrence
            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (numbers[middle] == target)
                {
                    result = middle;
                    left = middle + 1;
                }
                else if (numbers[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return result;
        }

        public void Display(int[] numbers, int target)
        {
            int first = FindFirst(numbers, target);
            int last = FindLast(numbers, target);

            Console.WriteLine($"First Occurrence: {first}");
            Console.WriteLine($"Last Occurrence: {last}");
        }
    }
}
