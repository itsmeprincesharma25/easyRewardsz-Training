using System;
using System.IO;

namespace Assignment
{
    class FileNotFoundHandling
    {
        public void ReadFile(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    throw new IOException();
                }

                string content = File.ReadAllText(fileName);
                Console.WriteLine(content);
            }
            catch (IOException)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}