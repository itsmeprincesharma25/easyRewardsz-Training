using System;

namespace Assignment
{
    class SearchWord
    {
        public string Find(string[] sentences, string word)
        {
            // Check each sentence from left to right
            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].Contains(word, StringComparison.OrdinalIgnoreCase))
                {
                    return sentences[i];
                }
            }

            return null;
        }

        public void Display(string[] sentences, string word)
        {
            string result = Find(sentences, word);

            if (result == null)
                Console.WriteLine("Word not found");
            else
                Console.WriteLine($"Sentence: {result}");
        }
    }
}