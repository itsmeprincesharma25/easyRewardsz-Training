using System;

namespace Assignment
{
    class PostgraduateStudent : Student
    {
        public PostgraduateStudent(int rollNumber, string name, double cgpa)
            : base(rollNumber, name, cgpa)
        {
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Roll Number : {rollNumber}");
            Console.WriteLine($"Name        : {name}");
            Console.WriteLine($"CGPA        : {GetCGPA()}");
        }
    }
}