using System;

namespace Assignment2
{
    class UniversityStudent
    {
        public static string UniversityName = "Chitkara University";
        private static int totalStudents = 0;

        private string name;
        public readonly int RollNumber;
        private string grade;

        // Parameterized constructor
        public UniversityStudent(string name, int rollNumber, string grade)
        {
            this.name = name;
            RollNumber = rollNumber;
            this.grade = grade;
            totalStudents++;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"University : {UniversityName}");
            Console.WriteLine($"Name       : {name}");
            Console.WriteLine($"Roll No.   : {RollNumber}");
            Console.WriteLine($"Grade      : {grade}");
        }

        public static void DisplayTotalStudents()
        {
            Console.WriteLine($"Total Students : {totalStudents}");
        }
    }
}