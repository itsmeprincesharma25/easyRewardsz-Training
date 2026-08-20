using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort\n");

            int[] marks = { 85, 62, 91, 45, 73 };

            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(marks);

            Console.WriteLine("Student Marks:");
            bubbleSort.Display(marks);


            Console.WriteLine("\nInsertion Sort\n");

            int[] employeeIds = { 105, 102, 108, 101, 104 };

            InsertionSort insertionSort = new InsertionSort();
            insertionSort.Sort(employeeIds);

            Console.WriteLine("Employee IDs:");
            insertionSort.Display(employeeIds);


            Console.WriteLine("\nMerge Sort\n");

            int[] bookPrices = { 450, 200, 800, 150, 600 };

            MergeSort mergeSort = new MergeSort();
            mergeSort.Sort(bookPrices, 0, bookPrices.Length - 1);

            Console.WriteLine("Book Prices:");
            mergeSort.Display(bookPrices);


            Console.WriteLine("\nQuick Sort\n");

            int[] productPrices = { 500, 120, 800, 300, 650 };

            QuickSort quickSort = new QuickSort();
            quickSort.Sort(productPrices, 0, productPrices.Length - 1);

            Console.WriteLine("Product Prices:");
            quickSort.Display(productPrices);


            Console.WriteLine("\nSelection Sort\n");

            int[] scores = { 78, 45, 92, 61, 35 };

            SelectionSort selectionSort = new SelectionSort();
            selectionSort.Sort(scores);

            Console.WriteLine("Exam Scores:");
            selectionSort.Display(scores);


            Console.WriteLine("\nHeap Sort\n");

            int[] salaries = { 50000, 30000, 80000, 45000, 70000 };

            HeapSort heapSort = new HeapSort();
            heapSort.Sort(salaries);

            Console.WriteLine("Salary Demands:");
            heapSort.Display(salaries);


            Console.WriteLine("\nCounting Sort\n");

            int[] ages = { 15, 12, 18, 10, 14, 12, 16 };

            CountingSort countingSort = new CountingSort();
            countingSort.Sort(ages);

            Console.WriteLine("Student Ages:");
            countingSort.Display(ages);
        }
    }
}