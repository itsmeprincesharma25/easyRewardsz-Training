using System;
using System.IO;

namespace Assignment
{
    class UsingFileHandling
    {
        public void ReadFirstLine(string fileName)
        {
            try
            {
                // using automatically closes the file
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line = reader.ReadLine();

                    Console.WriteLine(line);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading file");
            }
        }
    }
}