using System;

namespace Assignment
{
    class NestedTryCatch
    {
        public void Calculate(int[] numbers, int index, int divisor)
        {
            try
            {
                int value = numbers[index];

                try
                {
                    // Divide the selected array value
                    int result = value / divisor;

                    Console.WriteLine($"Result: {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
    }
}