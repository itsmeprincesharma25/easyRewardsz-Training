using System;

namespace Assignments
{
    public class Assignment1
    {
        // Question 1: Print welcome message
        public static void PrintWelcome()
        {
            Console.WriteLine("Welcome to Bridgelabz!");
        }

        // Question 2: Find the sum of two numbers
        public static void Sum()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Sum = {a + b}");
        }

        // Question 3: Convert Celsius to Fahrenheit
        public static void ConvertC2F()
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine()!);

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
        }

        // Question 4: Calculate area of a circle
        public static void AreaOfCircle()
        {
            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine()!);

            double area = Math.PI * r * r;

            Console.WriteLine($"Area = {area}");
        }

        // Question 5: Calculate volume of a cylinder
        public static void VolumeOfCylinder()
        {
            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine()!);

            Console.Write("Enter height: ");
            double h = double.Parse(Console.ReadLine()!);

            double volume = Math.PI * r * r * h;

            Console.WriteLine($"Volume = {volume}");
        }

        // Question 6: Calculate simple interest
        public static void SimpleInterest()
        {
            Console.Write("Enter principal amount: ");
            double p = double.Parse(Console.ReadLine()!);

            Console.Write("Enter rate of interest: ");
            double r = double.Parse(Console.ReadLine()!);

            Console.Write("Enter time: ");
            double t = double.Parse(Console.ReadLine()!);

            double si = (p * r * t) / 100;

            Console.WriteLine($"Simple Interest = {si}");
        }

        // Question 7: Calculate perimeter of a rectangle
        public static void PerimeterOfRectangle()
        {
            Console.Write("Enter length: ");
            int l = int.Parse(Console.ReadLine()!);

            Console.Write("Enter width: ");
            int w = int.Parse(Console.ReadLine()!);

            int perimeter = 2 * (l + w);

            Console.WriteLine($"Perimeter = {perimeter}");
        }

        // Question 8: Find the power of a number
        public static void Power()
        {
            Console.Write("Enter base: ");
            int number = int.Parse(Console.ReadLine()!);

            Console.Write("Enter power: ");
            int power = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Answer = {Math.Pow(number, power)}");
        }

        // Question 9: Calculate average of three numbers
        public static void Average()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine()!);

            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine()!);

            double average = (a + b + c) / 3.0;

            Console.WriteLine($"Average = {average}");
        }

        // Question 10: Convert kilometers to miles
        public static void KmToMiles()
        {
            Console.Write("Enter distance in kilometers: ");
            double km = double.Parse(Console.ReadLine()!);

            double miles = km * 0.621371;

            Console.WriteLine($"{km} km = {miles} miles");
        }
    }
}