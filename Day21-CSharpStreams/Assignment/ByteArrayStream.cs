using System;
using System.IO;

namespace Assignment
{
    class ByteArrayStream
    {
        public void CopyImage(string sourceFile, string destinationFile)
        {
            try
            {
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Source image does not exist.");
                    return;
                }

                // Read the image as a byte array
                byte[] imageData = File.ReadAllBytes(sourceFile);

                // Use MemoryStream to write the byte array
                using (MemoryStream stream = new MemoryStream())
                {
                    stream.Write(imageData, 0, imageData.Length);

                    // Create the new image file
                    File.WriteAllBytes(destinationFile, stream.ToArray());
                }

                Console.WriteLine("Image copied successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
        }
    }
}