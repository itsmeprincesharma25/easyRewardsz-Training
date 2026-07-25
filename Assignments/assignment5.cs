using System;

namespace Assignment
{
    class Assignment5
    {
        // Question 1 : Checking Validate Voting Age
        public static void VotingEligibility()
        {
            int totalStudents = 10;
            int[] ages = new int[totalStudents];
            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write($"Enter the age of student {i + 1} = ");
                ages[i] = int.Parse(Console.ReadLine()!);
            }
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < 0)
                {
                    Console.WriteLine($"Student {i + 1} : Invalid age {ages[i]}");
                }
                else if (ages[i] < 18)
                {
                    Console.WriteLine($"The student with the age {ages[i]} cannot vote.");
                }
                else
                {
                    Console.WriteLine($"The student with the age {ages[i]} can vote.");
                }
            }
        }

        // Question 2 
        public static void NumberAnalysis()
        {
            int[] nums = new int[5];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"Enter number {i + 1} = ");
                nums[i] = int.Parse(Console.ReadLine()!);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = nums[i];
                if (currentNum > 0)
                {
                    Console.Write($"{currentNum} is a Positive Number. ");
                    if (currentNum % 2 == 0)
                    {
                        Console.WriteLine("It is an even number.");
                    }
                    else
                    {
                        Console.WriteLine("It is an odd number.");
                    }
                }
                else if (currentNum == 0)
                {
                    Console.WriteLine("Zero");
                }
                else
                {
                    Console.WriteLine($"{currentNum} is a negative number.");
                }
            }
            int firstElement = nums[0];
            int lastElement = nums[nums.Length - 1];

            // Conditional block comparing first element against last element
            if (firstElement == lastElement)
            {
                Console.WriteLine($"1st element ({firstElement}) and Last element ({lastElement}) are EQUAL.");
            }
            else if (firstElement > lastElement)
            {
                Console.WriteLine($"1st element ({firstElement}) is GREATER than Last element ({lastElement}).");
            }
            else
            {
                Console.WriteLine($"1st element ({firstElement}) is LESS than Last element ({lastElement}).");
            }
        }

        // Question 3 : Table
        public static void MultiplicationTable() {
            
        }
        
    }
}