using System;
using System.IO.Pipes;
using System.Threading;

namespace Assignment
{
    class PipedStreams
    {
        public void Run()
        {
            using (AnonymousPipeServerStream pipeServer =
                   new AnonymousPipeServerStream(
                       PipeDirection.Out,
                       HandleInheritability.Inheritable))
            {
                string handle = pipeServer.GetClientHandleAsString();

                Thread writerThread = new Thread(() =>
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(pipeServer))
                        {
                            writer.AutoFlush = true;

                            // Send data through the pipe
                            writer.WriteLine("Hello from writer thread");
                            writer.WriteLine("Data sent using PipeStream");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Write error: {ex.Message}");
                    }
                });

                Thread readerThread = new Thread(() =>
                {
                    try
                    {
                        using (AnonymousPipeClientStream pipeClient =
                               new AnonymousPipeClientStream(
                                   PipeDirection.In,
                                   handle))
                        using (StreamReader reader = new StreamReader(pipeClient))
                        {
                            string line;

                            // Read data from the writer thread
                            while ((line = reader.ReadLine()) != null)
                            {
                                Console.WriteLine($"Reader: {line}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Read error: {ex.Message}");
                    }
                });

                readerThread.Start();
                writerThread.Start();

                writerThread.Join();
                readerThread.Join();
            }
        }
    }
}