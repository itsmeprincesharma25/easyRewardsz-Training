using System;
using System.Collections.Generic;

namespace Assignment
{
    class TwoSum
    {
        public void Find(int[] numbers, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int required = target - numbers[i];

                if (map.ContainsKey(required))
                {
                    Console.WriteLine($"Indices: {map[required]} and {i}");
                    return;
                }

                map[numbers[i]] = i;
            }

            Console.WriteLine("No pair found");
        }
    }
}
