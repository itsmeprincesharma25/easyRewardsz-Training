using System;

namespace Assignment
{
    class SelectionSort
    {
        public void Sort(int[] scores)
        {
            for (int i = 0; i < scores.Length - 1; i++)
            {
                int minIndex = i;

                // Find the smallest element in the unsorted part
                for (int j = i + 1; j < scores.Length; j++)
                {
                    if (scores[j] < scores[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Put the smallest element at the current position
                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }
        }

        public void Display(int[] scores)
        {
            foreach (int score in scores)
            {
                Console.Write(score + " ");
            }

            Console.WriteLine();
        }
    }
}