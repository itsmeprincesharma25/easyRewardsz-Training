using System;
using System.IO;

namespace Assignment
{
    class UserInput
    {
        public void SaveUserData(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
                {
                    Console.Write("Enter your name: ");
                    string name = reader.ReadLine();

                    Console.Write("Enter your age: ");
                    string age = reader.ReadLine();

                    Console.Write("Enter your favorite programming language: ");
                    string language = reader.ReadLine();

                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        // Save the entered information into the file
                        writer.WriteLine($"Name: {name}");
                        writer.WriteLine($"Age: {age}");
                        writer.WriteLine($"Favorite Language: {language}");
                    }
                }

                Console.WriteLine("User data saved successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
        }
    }
}