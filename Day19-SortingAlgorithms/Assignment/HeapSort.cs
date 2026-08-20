using System;

namespace Assignment
{
    class HeapSort
    {
        public void Sort(int[] salaries)
        {
            int n = salaries.Length;

            // Build a Max Heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(salaries, n, i);
            }

            // Move the largest element to the end
            for (int i = n - 1; i > 0; i--)
            {
                int temp = salaries[0];
                salaries[0] = salaries[i];
                salaries[i] = temp;

                // Restore the Max Heap
                Heapify(salaries, i, 0);
            }
        }

        private void Heapify(int[] salaries, int n, int root)
        {
            int largest = root;
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            if (left < n && salaries[left] > salaries[largest])
                largest = left;

            if (right < n && salaries[right] > salaries[largest])
                largest = right;

            if (largest != root)
            {
                int temp = salaries[root];
                salaries[root] = salaries[largest];
                salaries[largest] = temp;

                Heapify(salaries, n, largest);
            }
        }

        public void Display(int[] salaries)
        {
            foreach (int salary in salaries)
            {
                Console.Write(salary + " ");
            }

            Console.WriteLine();
        }
    }
}