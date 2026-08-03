using System;

namespace Practice
{
    class StringMethods
    {
        public static void ReverseString1(String s = "hellow")
        {
            Console.WriteLine($"Original String : {s}");
            char[] arr = s.ToCharArray();
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
            string reversed = new string(arr);
            Console.WriteLine($"Reversed String : {reversed}");
        }

        public static void ReverseString2(string s = "hellow")
        {
            Console.WriteLine($"Original String : {s}");
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);
            Console.WriteLine($"Reversed String : {reversed}");
        }

        public static void ReverseString3(string s = "hellow")
        {
            Console.WriteLine($"Original String : {s}");
            Console.Write("Reversed String : ");
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
            }
            Console.WriteLine();

        }

        public static void IsPalindrome(string s = "madam")
        {
            if (s.Length == 0) Console.WriteLine("Empty String");
            else
            {
                int left = 0;
                int right = s.Length - 1;
                bool isPalindrome = true;
                while (left < right)
                {
                    if (s[left] != s[right])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                Console.WriteLine($"Given String \"{s}\" is Palindrome : {isPalindrome}");

            }
        }

        public static void CountVowelsAndConsonants(string s = "hellow")
        {
            Console.WriteLine($"Given String : {s}");
            int vowels = 0;
            int consonants = 0;

            foreach (char c in s.ToLower())
            {
                if (c >= 'a' && c <= 'z')
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')   // "aeiou".Contains(c)
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }

            Console.WriteLine($"Vowels : {vowels}");
            Console.WriteLine($"Consonants  : {consonants}");
        }

        public static void CountFrequency(string s = "hellow")
        {
            Console.WriteLine($"Give String : {s}");
            int[] arr = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                arr[current - 'a']++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine($"freq of {(char)(i + 'a')} = {arr[i]} ");
                }
            }
        }

        public static void CountWords(string s = "My name is Prince Sharma.")
        {

            Console.WriteLine($"Give String : {s}");
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ' && (i == 0 || s[i - 1] == ' '))
                {
                    count++;
                }
            }

            Console.WriteLine($"Number of Words : {count}");
        }

        public static void ReverseLine(string s = "My name is Prince Sharma")
        {
            Console.WriteLine($"Give String : {s}");

            string[] arr = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                string temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
            string reversed = string.Join(" ", arr);
            Console.WriteLine($"Reversed : {reversed}");
        }

        public static void RemoveDuplicates(string s = "banana")
        {
            Console.WriteLine($"Given String : {s}");
            string updated = "";
            foreach (char c in s)
            {
                if (!updated.Contains(c))
                {
                    updated += c;
                }
            }
            Console.WriteLine($"Updated String : {updated}");
        }

        public static void Fre
    }
}