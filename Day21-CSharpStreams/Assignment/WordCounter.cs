using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment
{
    class WordCounter
    {
        public void CountWords(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    Console.WriteLine("File does not exist.");
                    return;
                }

                Dictionary<string, int> words =
                    new Dictionary<string, int>();

                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;

                    // Read the file line by line
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] lineWords = line
                            .ToLower()
                            .Split(
                                new char[] { ' ', '.', ',', '!', '?', ';', ':' },
                                StringSplitOptions.RemoveEmptyEntries
                            );

                        foreach (string word in lineWords)
                        {
                            if (words.ContainsKey(word))
                                words[word]++;
                            else
                                words[word] = 1;
                        }
                    }
                }

                Console.WriteLine("Top 5 Words:");

                // Sort words by frequency and take the top 5
                foreach (var word in words
                    .OrderByDescending(x => x.Value)
                    .Take(5))
                {
                    Console.WriteLine($"{word.Key} : {word.Value}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
        }
    }
}