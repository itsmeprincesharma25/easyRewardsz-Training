using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = "TestFiles";

            Directory.CreateDirectory(folder);

            string textFile = Path.Combine(folder, "source.txt");
            string copyFile = Path.Combine(folder, "copy.txt");

            File.WriteAllText(
                textFile,
                "Hello C# Streams\nThis is a sample file.\nError found here."
            );


            Console.WriteLine("File Handling\n");

            FileHandling fileHandling = new FileHandling();
            fileHandling.CopyFile(textFile, copyFile);


            Console.WriteLine("\nBuffered Streams\n");

            BufferedStreams buffered = new BufferedStreams();

            string bufferedFile = Path.Combine(folder, "buffered.txt");
            string normalFile = Path.Combine(folder, "normal.txt");

            buffered.CopyFile(textFile, bufferedFile);
            buffered.CopyWithoutBuffer(textFile, normalFile);


            Console.WriteLine("\nUser Input\n");

            UserInput userInput = new UserInput();

            string userFile = Path.Combine(folder, "user.txt");

            Console.WriteLine("Enter user details:");
            userInput.SaveUserData(userFile);


            Console.WriteLine("\nSerialization\n");

            Serialization serialization = new Serialization();

            string employeeFile = Path.Combine(folder, "employees.json");

            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Prince",
                    Department = "IT",
                    Salary = 50000
                },
                new Employee
                {
                    Id = 2,
                    Name = "Rahul",
                    Department = "HR",
                    Salary = 45000
                }
            };

            serialization.SaveEmployees(employeeFile, employees);
            serialization.LoadEmployees(employeeFile);


            Console.WriteLine("\nByteArray Stream\n");

            ByteArrayStream byteStream = new ByteArrayStream();

            string imageFile = Path.Combine(folder, "image.jpg");
            string imageCopy = Path.Combine(folder, "imageCopy.jpg");

            if (File.Exists(imageFile))
            {
                byteStream.CopyImage(imageFile, imageCopy);
            }
            else
            {
                Console.WriteLine("Image file not available for testing.");
            }


            Console.WriteLine("\nFilter Streams\n");

            FilterStreams filter = new FilterStreams();

            string lowerFile = Path.Combine(folder, "lowercase.txt");

            filter.ConvertToLower(textFile, lowerFile);


            Console.WriteLine("\nData Streams\n");

            DataStreams data = new DataStreams();

            string studentFile = Path.Combine(folder, "student.dat");

            data.SaveStudent(
                studentFile,
                101,
                "Prince",
                8.5
            );

            data.ReadStudent(studentFile);


            Console.WriteLine("\nPiped Streams\n");

            PipedStreams pipe = new PipedStreams();
            pipe.Run();


            Console.WriteLine("\nLarge File Reader\n");

            LargeFileReader largeFile = new LargeFileReader();
            largeFile.ReadFile(textFile);


            Console.WriteLine("\nWord Counter\n");

            WordCounter counter = new WordCounter();
            counter.CountWords(textFile);
        }
    }
}