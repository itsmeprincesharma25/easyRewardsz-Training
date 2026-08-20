using System;

namespace Assignment
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    class CustomException
    {
        public void ValidateAge(int age)
        {
            // Age below 18 is not allowed
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or above");
            }

            Console.WriteLine("Access granted!");
        }

        public void Run()
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                ValidateAge(age);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid age");
            }
        }
    }
}