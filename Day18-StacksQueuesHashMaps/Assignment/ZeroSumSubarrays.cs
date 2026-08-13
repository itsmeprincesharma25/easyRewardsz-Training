using System;
using System.Collections.Generic;

namespace Assignment
{
    class ZeroSumSubarrays
    {
        public void Find(int[] numbers)
        {
            Dictionary<int, List<int>> sums =
                new Dictionary<int, List<int>>();

            int sum = 0;

            sums[0] = new List<int> { -1 };

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];

                if (sums.ContainsKey(sum))
                {
                    foreach (int start in sums[sum])
                    {
                        Console.WriteLine(
                            $"Subarray: {start + 1} to {i}"
                        );
                    }

                    sums[sum].Add(i);
                }
                else
                {
                    sums[sum] = new List<int> { i };
                }
            }
        }
    }
}
