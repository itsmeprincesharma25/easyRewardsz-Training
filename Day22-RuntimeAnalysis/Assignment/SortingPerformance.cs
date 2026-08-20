using System;
using System.Diagnostics;

namespace Assignment
{
    class SortingPerformance
    {
        public void BubbleSort(int[] numbers)
        {
            // Compare adjacent elements and swap them
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
        }

        public void MergeSort(int[] numbers, int left, int right)
        {
            if (left >= right)
                return;

            // Divide the array into two parts
            int middle = left + (right - left) / 2;

            MergeSort(numbers, left, middle);
            MergeSort(numbers, middle + 1, right);

            Merge(numbers, left, middle, right);
        }

        private void Merge(int[] numbers, int left, int middle, int right)
        {
            int[] temp = new int[right - left + 1];

            int i = left;
            int j = middle + 1;
            int k = 0;

            // Merge both sorted parts
            while (i <= middle && j <= right)
            {
                if (numbers[i] <= numbers[j])
                    temp[k++] = numbers[i++];
                else
                    temp[k++] = numbers[j++];
            }

            while (i <= middle)
                temp[k++] = numbers[i++];

            while (j <= right)
                temp[k++] = numbers[j++];

            for (int x = 0; x < temp.Length; x++)
                numbers[left + x] = temp[x];
        }

        public void QuickSort(int[] numbers, int low, int high)
        {
            if (low >= high)
                return;

            // Partition the array around a pivot
            int pivot = Partition(numbers, low, high);

            QuickSort(numbers, low, pivot - 1);
            QuickSort(numbers, pivot + 1, high);
        }

        private int Partition(int[] numbers, int low, int high)
        {
            int pivot = numbers[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (numbers[j] < pivot)
                {
                    i++;

                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }

            int swap = numbers[i + 1];
            numbers[i + 1] = numbers[high];
            numbers[high] = swap;

            return i + 1;
        }

        public void Compare(int size)
        {
            Random random = new Random();

            int[] original = new int[size];

            for (int i = 0; i < size; i++)
            {
                original[i] = random.Next(1, 100000);
            }

            int[] bubbleArray = (int[])original.Clone();
            int[] mergeArray = (int[])original.Clone();
            int[] quickArray = (int[])original.Clone();

            Stopwatch watch = new Stopwatch();

            watch.Start();
            BubbleSort(bubbleArray);
            watch.Stop();

            long bubbleTime = watch.ElapsedMilliseconds;

            watch.Reset();

            watch.Start();
            MergeSort(mergeArray, 0, mergeArray.Length - 1);
            watch.Stop();

            long mergeTime = watch.ElapsedMilliseconds;

            watch.Reset();

            watch.Start();
            QuickSort(quickArray, 0, quickArray.Length - 1);
            watch.Stop();

            long quickTime = watch.ElapsedMilliseconds;

            Console.WriteLine($"Dataset Size: {size}");
            Console.WriteLine($"Bubble Sort: {bubbleTime} ms");
            Console.WriteLine($"Merge Sort: {mergeTime} ms");
            Console.WriteLine($"Quick Sort: {quickTime} ms");
            Console.WriteLine();
        }
    }
}