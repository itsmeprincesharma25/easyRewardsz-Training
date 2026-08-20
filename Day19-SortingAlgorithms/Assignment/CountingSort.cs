using System;

namespace Assignment
{
    class CountingSort
    {
        public void Sort(int[] ages)
        {
            if (ages.Length == 0)
                return;

            int min = 10;
            int max = 18;

            int[] count = new int[max - min + 1];

            // Count how many times each age occurs
            foreach (int age in ages)
            {
                count[age - min]++;
            }

            // Put the sorted values back into the array
            int index = 0;

            for (int i = 0; i < count.Length; i++)
            {
                while (count[i] > 0)
                {
                    ages[index] = i + min;
                    index++;
                    count[i]--;
                }
            }
        }

        public void Display(int[] ages)
        {
            foreach (int age in ages)
            {
                Console.Write(age + " ");
            }

            Console.WriteLine();
        }
    }
}