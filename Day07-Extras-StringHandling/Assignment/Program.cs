using System;

namespace Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            Assignment7.CountLetters("Hello World");

            // Question 2
            Console.WriteLine(Assignment7.ReverseString("Bridgelabz"));

            // Question 3
            Console.WriteLine(Assignment7.IsPalindrome("madam"));

            // Question 4
            Console.WriteLine(Assignment7.RemoveDuplicate("programming"));

            // Question 5
            Console.WriteLine(Assignment7.LongestWord("I love C# programming"));

            // Question 6
            Console.WriteLine(Assignment7.CountSubstring("banana", "an"));

            // Question 7
            Console.WriteLine(Assignment7.ToggleCase("Hello World"));

            // Question 8
            Console.WriteLine(Assignment7.CompareString("apple", "apple"));

            // Question 9
            Console.WriteLine(Assignment7.MostFrequentChar("success"));

            // Question 10
            Console.WriteLine(Assignment7.RemoveChar("banana", 'a'));

            // Question 11
            Console.WriteLine(Assignment7.IsAnagram("listen", "silent"));

            // Question 12
            Console.WriteLine(Assignment7.ReplaceWord("I like Java", "Java", "C#"));
        }
    }
}