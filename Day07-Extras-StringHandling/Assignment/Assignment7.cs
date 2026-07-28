using System;

namespace Assignments
{
    public class Assignment7
    {
        public static void CountLetters(string str)
        {
            int vowel = 0;
            int cons = 0;

            foreach (char ch in str.ToLower())
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    // Check if the character is a vowel
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    {
                        vowel++;
                    }
                    else
                    {
                        cons++;
                    }
                }
            }

            Console.WriteLine("Vowels     : " + vowel);
            Console.WriteLine("Consonants : " + cons);
        }

        // Question 2 : Reverse a String
        public static string ReverseString(string str)
        {
            string rev = "";

            // Reverse the string manually
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }

            return rev;
        }

        // Question 3 : To check String is Palindrome or not.
        public static bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            // Compare characters from both ends
            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        // Question 4. Remove Duplicates from a String
        public static string RemoveDuplicate(string str)
        {
            string ans = "";

            foreach (char ch in str)
            {
                // Add character only once
                if (!ans.Contains(ch))
                {
                    ans += ch;
                }
            }

            return ans;
        }

        // Question 5. Find the Longest Word in a Sentence
        public static string LongestWord(string str)
        {
            string[] arr = str.Split(' ');
            string word = "";

            foreach (string s in arr)
            {
                if (s.Length > word.Length)
                {
                    word = s;
                }
            }

            return word;
        }

        // Question 6. Find Substring Occurrences
        public static int CountSubstring(string str, string sub)
        {
            int cnt = 0;

            for (int i = 0; i <= str.Length - sub.Length; i++)
            {
                if (str.Substring(i, sub.Length) == sub)
                {
                    cnt++;
                }
            }

            return cnt;
        }

        // Question 7. Toggle Case of Characters
        public static string ToggleCase(string str)
        {
            string ans = "";

            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    ans += char.ToLower(ch);
                }
                else if (char.IsLower(ch))
                {
                    ans += char.ToUpper(ch);
                }
                else
                {
                    ans += ch;
                }
            }

            return ans;
        }

        // Question 8. Compare Two Strings
        public static int CompareString(string s1, string s2)
        {
            int len = Math.Min(s1.Length, s2.Length);

            for (int i = 0; i < len; i++)
            {
                if (s1[i] < s2[i])
                {
                    return -1;
                }

                if (s1[i] > s2[i])
                {
                    return 1;
                }
            }

            if (s1.Length == s2.Length)
            {
                return 0;
            }

            return s1.Length < s2.Length ? -1 : 1;
        }

        // Question 9. Find the Most Frequent Character
        public static char MostFrequentChar(string str)
        {
            int max = 0;
            char ans = '\0';

            foreach (char ch in str)
            {
                int cnt = 0;

                foreach (char c in str)
                {
                    if (ch == c)
                    {
                        cnt++;
                    }
                }

                if (cnt > max)
                {
                    max = cnt;
                    ans = ch;
                }
            }

            return ans;
        }

        // Question 10. Remove a Specific Character from a String
        public static string RemoveChar(string str, char ch)
        {
            string ans = "";

            foreach (char c in str)
            {
                // Skip the given character
                if (c != ch)
                {
                    ans += c;
                }
            }

            return ans;
        }

        // Question 11 . Anagram Check
        public static bool IsAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            char[] a = s1.ToLower().ToCharArray();
            char[] b = s2.ToLower().ToCharArray();

            Array.Sort(a);
            Array.Sort(b);

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }

        // Question 12. Replace a Word in a Sentence
        public static string ReplaceWord(string str, string oldWord, string newWord)
        {
            string[] arr = str.Split(' ');
            string ans = "";

            foreach (string word in arr)
            {
                if (word == oldWord)
                {
                    ans += newWord + " ";
                }
                else
                {
                    ans += word + " ";
                }
            }

            return ans.Trim();
        }
    }
}