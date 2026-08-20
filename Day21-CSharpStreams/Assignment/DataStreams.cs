using System;
using System.IO;

namespace Assignment
{
    class DataStreams
    {
        public void SaveStudent(string fileName, int rollNumber, string name, double gpa)
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(
                    File.Open(fileName, FileMode.Create)))
                {
                    // Write student data in binary format
                    writer.Write(rollNumber);
                    writer.Write(name);
                    writer.Write(gpa);
                }

                Console.WriteLine("Student data saved successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
        }

        public void ReadStudent(string fileName)
        {
            try
            {
                using (BinaryReader reader = new BinaryReader(
                    File.Open(fileName, FileMode.Open)))
                {
                    // Read data in the same order in which it was written
                    int rollNumber = reader.ReadInt32();
                    string name = reader.ReadString();
                    double gpa = reader.ReadDouble();

                    Console.WriteLine($"Roll Number: {rollNumber}");
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"GPA: {gpa}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
        }
    }
}