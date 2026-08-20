using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Assignment
{
    class FileReadingPerformance
    {
        public void Compare(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("File does not exist.");
                return;
            }

            Stopwatch watch = new Stopwatch();

            // Read the file using StreamReader
            watch.Start();

            using (StreamReader reader = new StreamReader(fileName))
            {
                while (reader.ReadLine() != null)
                {
                }
            }

            watch.Stop();

            long streamReaderTime = watch.ElapsedMilliseconds;

            watch.Reset();

            // Read the file using FileStream
            watch.Start();

            using (FileStream stream = new FileStream(
                fileName, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[4096];

                while (stream.Read(buffer, 0, buffer.Length) > 0)
                {
                }
            }

            watch.Stop();

            long fileStreamTime = watch.ElapsedMilliseconds;

            Console.WriteLine($"StreamReader: {streamReaderTime} ms");
            Console.WriteLine($"FileStream: {fileStreamTime} ms");
        }
    }
}