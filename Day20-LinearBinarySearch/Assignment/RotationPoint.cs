using System;

namespace Assignment
{
    class RotationPoint
    {
        public int Find(int[] numbers)
        {
            int left = 0;
            int right = numbers.Length - 1;

            // Binary Search for the smallest element
            while (left < right)
            {
                int middle = left + (right - left) / 2;

                if (numbers[middle] > numbers[right])
                {
                    // Smallest element is on the right side
                    left = middle + 1;
                }
                else
                {
                    // Smallest element is at middle or on the left
                    right = middle;
                }
            }

            return left;
        }

        public void Display(int[] numbers)
        {
            int index = Find(numbers);

            Console.WriteLine($"Rotation Point Index: {index}");
            Console.WriteLine($"Smallest Element: {numbers[index]}");
        }
    }
}