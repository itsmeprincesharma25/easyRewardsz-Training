using System;
using System.IO;
using System.Text;

namespace Assignment
{
    class FilterStreams
    {
        public void ConvertToLower(string sourceFile, string destinationFile)
        {
            try
            {
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Source file does not exist.");
                    return;
                }

                using (FileStream inputFile = new FileStream(
                    sourceFile, FileMode.Open, FileAccess.Read))
                using (FileStream outputFile = new FileStream(
                    destinationFile, FileMode.Create, FileAccess.Write))
                using (BufferedStream inputBuffer = new BufferedStream(inputFile))
                using (BufferedStream outputBuffer = new BufferedStream(outputFile))
                using (StreamReader reader = new StreamReader(inputBuffer, Encoding.UTF8))
                using (StreamWriter writer = new StreamWriter(outputBuffer, Encoding.UTF8))
                {
                    string line;

                    // Read each line and convert it to lowercase
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line.ToLower());
                    }
                }

                Console.WriteLine("File converted successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
        }
    }
}
