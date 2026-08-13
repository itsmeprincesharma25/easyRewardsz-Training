using System;
using System.Collections.Generic;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue Using Stacks\n");

            QueueUsingStacks queue = new QueueUsingStacks();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Peek: " + queue.Peek());


            Console.WriteLine("\nSort Stack\n");

            Stack<int> stack = new Stack<int>();
            stack.Push(30);
            stack.Push(10);
            stack.Push(40);
            stack.Push(20);

            SortStack sortStack = new SortStack();
            sortStack.Sort(stack);

            Console.WriteLine("Sorted Stack:");
            sortStack.Display(stack);


            Console.WriteLine("\nStock Span\n");

            int[] prices = { 100, 80, 60, 70, 60, 75, 85 };

            StockSpan stockSpan = new StockSpan();
            int[] spans = stockSpan.CalculateSpan(prices);

            Console.WriteLine("Span:");
            stockSpan.Display(spans);


            Console.WriteLine("\nSliding Window Maximum\n");

            int[] numbers = { 1, 3, -1, -3, 5, 3, 6, 7 };

            SlidingWindowMaximum window = new SlidingWindowMaximum();
            int[] maximums = window.FindMaximum(numbers, 3);

            Console.WriteLine("Maximums:");
            window.Display(maximums);


            Console.WriteLine("\nCircular Tour\n");

            PetrolPump[] pumps =
            {
                new PetrolPump(6, 4),
                new PetrolPump(3, 6),
                new PetrolPump(7, 3),
                new PetrolPump(4, 5)
            };

            CircularTour tour = new CircularTour();
            int start = tour.FindStartingPoint(pumps);

            tour.DisplayResult(start);


            Console.WriteLine("\nZero Sum Subarrays\n");

            int[] zeroArray =
            {
                6, 3, -1, -3, 4, -2, 2, 4, 6, -12, -7
            };

            ZeroSumSubarrays zeroSum = new ZeroSumSubarrays();
            zeroSum.Find(zeroArray);


            Console.WriteLine("\nPair With Given Sum\n");

            int[] pairArray = { 2, 7, 11, 15 };

            PairWithGivenSum pair = new PairWithGivenSum();
            pair.FindPair(pairArray, 9);


            Console.WriteLine("\nCustom Hash Map\n");

            CustomHashMap map = new CustomHashMap(5);

            map.Insert(1, "Prince");
            map.Insert(2, "Rahul");
            map.Insert(3, "Aman");

            Console.WriteLine("Key 1: " + map.Get(1));

            map.Delete(2);

            Console.WriteLine("Key 2: " + map.Get(2));


            Console.WriteLine("\nTwo Sum\n");

            int[] twoSumArray = { 2, 7, 11, 15 };

            TwoSum twoSum = new TwoSum();
            twoSum.Find(twoSumArray, 9);
        }
    }
}