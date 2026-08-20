using System;

namespace Assignment
{
    class MergeSort
    {
        public void Sort(int[] prices, int left, int right)
        {
            if (left >= right)
                return;

            // Divide the array into two halves
            int middle = (left + right) / 2;

            Sort(prices, left, middle);
            Sort(prices, middle + 1, right);

            // Merge the two sorted halves
            Merge(prices, left, middle, right);
        }

        private void Merge(int[] prices, int left, int middle, int right)
        {
            int[] temp = new int[right - left + 1];

            int i = left;
            int j = middle + 1;
            int k = 0;

            // Compare both halves and store smaller element
            while (i <= middle && j <= right)
            {
                if (prices[i] <= prices[j])
                {
                    temp[k] = prices[i];
                    i++;
                }
                else
                {
                    temp[k] = prices[j];
                    j++;
                }

                k++;
            }

            // Copy remaining elements from left half
            while (i <= middle)
            {
                temp[k] = prices[i];
                i++;
                k++;
            }

            // Copy remaining elements from right half
            while (j <= right)
            {
                temp[k] = prices[j];
                j++;
                k++;
            }

            // Copy sorted elements back to original array
            for (int x = 0; x < temp.Length; x++)
            {
                prices[left + x] = temp[x];
            }
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