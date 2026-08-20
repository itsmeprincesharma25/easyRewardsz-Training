using System;
using System.IO;

namespace Assignment
{
    class FileHandling
    {
        public void CopyFile(string sourceFile, string destinationFile)
        {
            try
            {
                // Check whether the source file exists
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Source file does not exist.");
                    return;
                }

                // Read from source and write to destination
                using (FileStream source = new FileStream(
                    sourceFile, FileMode.Open, FileAccess.Read))
                using (FileStream destination = new FileStream(
                    destinationFile, FileMode.Create, FileAccess.Write))
                {
                    source.CopyTo(destination);
                }

                Console.WriteLine("File copied successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
        }
    }
}