using System;

namespace Assignment
{
    class InsertionSort
    {
        public void Sort(int[] employeeIds)
        {
            // Start from the second element because the first is already sorted
            for (int i = 1; i < employeeIds.Length; i++)
            {
                int current = employeeIds[i];
                int j = i - 1;

                // Move larger elements one position to the right
                while (j >= 0 && employeeIds[j] > current)
                {
                    employeeIds[j + 1] = employeeIds[j];
                    j--;
                }

                // Insert the current element at its correct position
                employeeIds[j + 1] = current;
            }
        }

        public void Display(int[] employeeIds)
        {
            foreach (int id in employeeIds)
            {
                Console.Write(id + " ");
            }

            Console.WriteLine();
        }
    }
}