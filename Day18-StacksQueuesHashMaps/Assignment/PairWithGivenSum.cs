using System;
using System.Collections.Generic;

namespace Assignment
{
    class PairWithGivenSum
    {
        public void FindPair(int[] numbers, int target)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int number in numbers)
            {
                int required = target - number;

                if (seen.Contains(required))
                {
                    Console.WriteLine(
                        $"Pair: {required} + {number} = {target}"
                    );

                    return;
                }

                seen.Add(number);
            }

            Console.WriteLine("No pair found");
        }
    }
}