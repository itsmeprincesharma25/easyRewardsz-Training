using System;
using System.Diagnostics;
using System.IO;

namespace Assignment
{
    class BufferedStreams
    {
        public void CopyFile(string sourceFile, string destinationFile)
        {
            try
            {
                Stopwatch watch = Stopwatch.StartNew();

                using (FileStream source = new FileStream(
                    sourceFile, FileMode.Open, FileAccess.Read))
                using (FileStream destination = new FileStream(
                    destinationFile, FileMode.Create, FileAccess.Write))
                using (BufferedStream input = new BufferedStream(source, 4096))
                using (BufferedStream output = new BufferedStream(destination, 4096))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;

                    // Copy the file in 4 KB chunks
                    while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        output.Write(buffer, 0, bytesRead);
                    }
                }

                watch.Stop();

                Console.WriteLine(
                    $"Buffered copy completed in {watch.ElapsedMilliseconds} ms"
                );
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
        }

        public void CopyWithoutBuffer(string sourceFile, string destinationFile)
        {
            try
            {
                Stopwatch watch = Stopwatch.StartNew();

                using (FileStream source = new FileStream(
                    sourceFile, FileMode.Open, FileAccess.Read))
                using (FileStream destination = new FileStream(
                    destinationFile, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;

                    // Copy using normal FileStream
                    while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        destination.Write(buffer, 0, bytesRead);
                    }
                }

                watch.Stop();

                Console.WriteLine(
                    $"Normal copy completed in {watch.ElapsedMilliseconds} ms"
                );
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
        }
    }
}