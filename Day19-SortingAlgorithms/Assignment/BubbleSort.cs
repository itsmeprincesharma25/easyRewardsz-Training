using System;

namespace Assignment
{
    class BubbleSort
    {
        public void Sort(int[] marks)
        {
            // Compare adjacent elements and move the largest to the end
            for (int i = 0; i < marks.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < marks.Length - i - 1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;

                        swapped = true;
                    }
                }

                // Stop if the array is already sorted
                if (!swapped)
                    break;
            }
        }

        public void Display(int[] marks)
        {
            foreach (int mark in marks)
            {
                Console.Write(mark + " ");
            }

            Console.WriteLine();
        }
    }
}