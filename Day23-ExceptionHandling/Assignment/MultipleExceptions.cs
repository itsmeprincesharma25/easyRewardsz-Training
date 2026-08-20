using System;

namespace Assignment
{
    class MultipleExceptions
    {
        public void GetValue(int[] numbers, int index)
        {
            try
            {
                // Access the array using the given index
                Console.WriteLine($"Value at index {index}: {numbers[index]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Array is not initialized!");
            }
        }
    }
}