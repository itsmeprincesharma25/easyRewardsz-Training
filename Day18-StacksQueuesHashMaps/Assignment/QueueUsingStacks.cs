using System;
using System.Collections.Generic;

namespace Assignment
{
    class QueueUsingStacks
    {
        private Stack<int> stack1 = new Stack<int>();
        private Stack<int> stack2 = new Stack<int>();

        public void Enqueue(int value)
        {
            stack1.Push(value);
        }

        public int Dequeue()
        {
            if (stack1.Count == 0 && stack2.Count == 0)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }

            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            return stack2.Pop();
        }

        public int Peek()
        {
            if (stack1.Count == 0 && stack2.Count == 0)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }

            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            return stack2.Peek();
        }

        public void Display()
        {
            Console.WriteLine("Queue:");

            foreach (int value in stack2)
            {
                Console.WriteLine(value);
            }
        }
    }
}