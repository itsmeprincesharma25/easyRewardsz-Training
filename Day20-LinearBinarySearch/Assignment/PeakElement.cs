using System;

namespace Assignment
{
    class PeakElement
    {
        public int Find(int[] numbers)
        {
            int left = 0;
            int right = numbers.Length - 1;

            // Use Binary Search to find a peak
            while (left < right)
            {
                int middle = left + (right - left) / 2;

                if (numbers[middle] < numbers[middle + 1])
                {
                    // Peak is on the right side
                    left = middle + 1;
                }
                else
                {
                    // Peak is at middle or on the left side
                    right = middle;
                }
            }

            return left;
        }

        public void Display(int[] numbers)
        {
            int index = Find(numbers);

            Console.WriteLine($"Peak Index: {index}");
            Console.WriteLine($"Peak Element: {numbers[index]}");
        }
    }
}