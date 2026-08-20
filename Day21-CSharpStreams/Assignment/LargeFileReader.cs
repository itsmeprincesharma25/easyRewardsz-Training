using System;
using System.IO;

namespace Assignment
{
    class LargeFileReader
    {
        public void ReadFile(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    Console.WriteLine("File does not exist.");
                    return;
                }

                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;

                    // Read one line at a time instead of loading the whole file
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains("error", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
        }
    }
}