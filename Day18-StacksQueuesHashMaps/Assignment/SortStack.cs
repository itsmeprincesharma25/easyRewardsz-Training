using System;
using System.Collections.Generic;

namespace Assignment
{
    class SortStack
    {
        public void Sort(Stack<int> stack)
        {
            if (stack.Count <= 1)
                return;

            int value = stack.Pop();

            Sort(stack);

            Insert(stack, value);
        }

        private void Insert(Stack<int> stack, int value)
        {
            if (stack.Count == 0 || stack.Peek() <= value)
            {
                stack.Push(value);
                return;
            }

            int top = stack.Pop();

            Insert(stack, value);

            stack.Push(top);
        }

        public void Display(Stack<int> stack)
        {
            foreach (int value in stack)
            {
                Console.WriteLine(value);
            }
        }
    }
}