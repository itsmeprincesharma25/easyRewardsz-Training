using System;
using System.Collections.Generic;

namespace Assignment
{
    class SlidingWindowMaximum
    {
        public int[] FindMaximum(int[] numbers, int k)
        {
            if (numbers.Length == 0 || k <= 0 || k > numbers.Length)
                return new int[0];

            int[] result = new int[numbers.Length - k + 1];
            LinkedList<int> deque = new LinkedList<int>();

            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                while (deque.Count > 0 &&
                       deque.First.Value <= i - k)
                {
                    deque.RemoveFirst();
                }

                while (deque.Count > 0 &&
                       numbers[deque.Last.Value] <= numbers[i])
                {
                    deque.RemoveLast();
                }

                deque.AddLast(i);

                if (i >= k - 1)
                {
                    result[index] = numbers[deque.First.Value];
                    index++;
                }
            }

            return result;
        }

        public void Display(int[] result)
        {
            foreach (int value in result)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
        }
    }
}