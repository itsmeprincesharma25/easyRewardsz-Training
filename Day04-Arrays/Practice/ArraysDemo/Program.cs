using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ways to define an array

            int[] array1 = new int[5]; // Array of 5 integers
                                       // we have to give the size of the array when we define it
                                       // other wise it will give an error

            int[] array2 = new int[] { 1, 2, 3, 4, 5 }; // Array of 5 integers with values
                                                        // we can define the array with values without giving the size of the array

            int[] array3 = { 1, 2, 3, 4, 5 }; // Array of 5 integers with values
                                              // we can define the array with values without giving the size of the array


            // Input values in an array by loop
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"Enter value for array1[{i}]: ");
                //Console.WriteLine("Enter value for array1[{0}]: ", i); its is a different method
                array1[i] = int.Parse(Console.ReadLine()!);
            }

            // Print values of an array by loop
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"array1[{i}] = {array1[i]}");
            }

            // Sum of an Array useing foreach loop
            foreach (int i in array2)
            {
                Console.Write(i + " ");
            }

            // Finding max
            int max = array1[0];
            for (int i = 1; i < array1.Length; i++)
            {
                if (array1[i] > max) { max = array1[i]; }
            }
            Console.WriteLine($"Max Element : {max}");

            // Finding Min
            int min = array1[0];
            for (int i = 1; i < array1.Length; i++)
            {
                if (array1[i] < min) { min = array1[i]; }
            }
            Console.WriteLine($"Min Element :  {min}");


            Triangle.checkTriangle();


        }
    }
}