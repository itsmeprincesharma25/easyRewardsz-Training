using System;

namespace Assignment
{
    class Student
    {
        public int RollNo;
        public string Name;
        public int Age;
        public char Grade;

        public Student(int rollNo, string name, int age, char grade)
        {
            RollNo = rollNo;
            Name = name;
            Age = age;
            Grade = grade;
        }
    }

    class StudentNode
    {
        public Student Data;
        public StudentNode Next;

        public StudentNode(Student data)
        {
            Data = data;
            Next = null;
        }
    }

    class StudentRecord
    {
        private StudentNode head;

        // Add student at the beginning
        public void AddAtBeginning(Student student)
        {
            StudentNode newNode = new StudentNode(student);
            newNode.Next = head;
            head = newNode;
        }

        // Add student at the end
        public void AddAtEnd(Student student)
        {
            StudentNode newNode = new StudentNode(student);

            if (head == null)
            {
                head = newNode;
                return;
            }

            StudentNode current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        // Add student at a position
        public void AddAtPosition(Student student, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(student);
                return;
            }

            StudentNode current = head;

            for (int i = 1; i < position - 1 && current != null; i++)
            {
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            StudentNode newNode = new StudentNode(student);
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void DeleteStudent(int rollNo)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (head.Data.RollNo == rollNo)
            {
                head = head.Next;
                return;
            }

            StudentNode current = head;

            while (current.Next != null)
            {
                if (current.Next.Data.RollNo == rollNo)
                {
                    current.Next = current.Next.Next;
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("Student not found");
        }

        public void SearchStudent(int rollNo)
        {
            StudentNode current = head;

            while (current != null)
            {
                if (current.Data.RollNo == rollNo)
                {
                    Console.WriteLine("Student Found");
                    Console.WriteLine($"Roll No : {current.Data.RollNo}");
                    Console.WriteLine($"Name    : {current.Data.Name}");
                    Console.WriteLine($"Age     : {current.Data.Age}");
                    Console.WriteLine($"Grade   : {current.Data.Grade}");
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("Student not found");
        }

        public void DisplayStudents()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            StudentNode current = head;

            while (current != null)
            {
                Console.WriteLine(
                    $"{current.Data.RollNo} - {current.Data.Name} - {current.Data.Age} - {current.Data.Grade}"
                );

                current = current.Next;
            }
        }

        public void UpdateGrade(int rollNo, char grade)
        {
            StudentNode current = head;

            while (current != null)
            {
                if (current.Data.RollNo == rollNo)
                {
                    current.Data.Grade = grade;
                    Console.WriteLine("Grade updated");
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("Student not found");
        }
    }
}