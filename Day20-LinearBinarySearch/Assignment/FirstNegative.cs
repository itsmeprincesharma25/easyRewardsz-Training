using System;

namespace Assignment
{
    class FirstNegative
    {
        public int Find(int[] numbers)
        {
            // Check each element from left to right
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    return numbers[i];
                }
            }

            return -1;
        }

        public void Display(int[] numbers)
        {
            int result = Find(numbers);

            if (result == -1)
                Console.WriteLine("No negative number found");
            else
                Console.WriteLine($"First Negative Number: {result}");
        }
    }
}