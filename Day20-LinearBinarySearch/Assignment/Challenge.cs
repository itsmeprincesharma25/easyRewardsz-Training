using System;

namespace Assignment
{
    class Challenge
    {
        public int FindMissingPositive(int[] numbers)
        {
            // Mark positive numbers that are present
            bool[] present = new bool[numbers.Length + 1];

            foreach (int number in numbers)
            {
                if (number > 0 && number <= numbers.Length)
                {
                    present[number] = true;
                }
            }

            // Find the first missing positive number
            for (int i = 1; i < present.Length; i++)
            {
                if (!present[i])
                    return i;
            }

            return numbers.Length + 1;
        }

        public int BinarySearch(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            // Search the target using Binary Search
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

        public void Display(int[] numbers, int target)
        {
            int missing = FindMissingPositive(numbers);
            Console.WriteLine($"First Missing Positive: {missing}");

            int index = BinarySearch(numbers, target);
            Console.WriteLine($"Target Index: {index}");
        }
    }
}
