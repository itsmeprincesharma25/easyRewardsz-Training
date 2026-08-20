using System;

namespace Assignment
{
    class QuickSort
    {
        public void Sort(int[] prices, int low, int high)
        {
            if (low >= high)
                return;

            // Choose a pivot and divide the array around it
            int pivotIndex = Partition(prices, low, high);

            // Sort the left and right parts
            Sort(prices, low, pivotIndex - 1);
            Sort(prices, pivotIndex + 1, high);
        }

        private int Partition(int[] prices, int low, int high)
        {
            // Take the last element as pivot
            int pivot = prices[high];

            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (prices[j] < pivot)
                {
                    i++;

                    int temp = prices[i];
                    prices[i] = prices[j];
                    prices[j] = temp;
                }
            }

            // Put pivot in its correct position
            int swap = prices[i + 1];
            prices[i + 1] = prices[high];
            prices[high] = swap;

            return i + 1;
        }

        public void Display(int[] prices)
        {
            foreach (int price in prices)
            {
                Console.Write(price + " ");
            }

            Console.WriteLine();
        }
    }
}