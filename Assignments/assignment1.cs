using System;

namespace Assignment1
{
    public class Assignment1
    {
        // Question 1
        public static void PrintWelcome()
        {
            Console.WriteLine("Welcome to Bridgelabz!");
        }

        // Question 2
        public static void Sum()
        {
            Console.Write("Enter 1st Number : ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Enter 2nd Number : ");
            int b = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Sum of {a} and {b} = {a + b}");
        }

        // Question 3
        public static void ConvertC2F()
        {
            Console.Write("Enter temperature in Celcius : ");
            double Celsius = double.Parse(Console.ReadLine()!);
            double Fahrenheit = (Celsius * 9 / 5) + 32;
            Console.WriteLine($"{Celsius} C = {Fahrenheit} F");
        }

        // Question 4
        public static void AreaOfCircle()
        {
            Console.Write("Enter radius of Circle : ");
            double r = double.Parse(Console.ReadLine()!);
            double area = Math.PI * r * r;
            Console.WriteLine($"Area of Circle with radius {r} is : {area}");
        }

        // Question 5
        public static void VolumeOfCylinder()
        {
            Console.Write("Enter radius of Cylinder : ");
            double r = double.Parse(Console.ReadLine()!);
            Console.Write("Enter height of Cylinder : ");
            double h = double.Parse(Console.ReadLine()!);
            double volume = Math.PI * r * r * h;
            Console.WriteLine($"Volume of Cylinder is : {volume}");
        }

        // Question 6
        public static void SimpleInterest()
        {
            Console.Write("Enter Principal amount : ");
            double p = double.Parse(Console.ReadLine()!);
            Console.Write("Enter rate of Interest : ");
            double r = double.Parse(Console.ReadLine()!);
            Console.Write("Enter time : ");
            double t = double.Parse(Console.ReadLine()!);
            double si = (p * r * t) / 100;
            Console.WriteLine($"Simple Interest : {si}");
        }

        // Question 7
        public static void PerimeterOfRectangle()
        {
            Console.Write("Enter Length: ");
            int l = int.Parse(Console.ReadLine()!);
            Console.Write("Enter Width : ");
            int w = int.Parse(Console.ReadLine()!);
            int perimeter = 2 * (l + w);
            Console.WriteLine($"Perimeter of Rectangle  = {perimeter}");
        }

        // Question 8
        public static void Power()
        {
            Console.Write("Enter base : ");
            int number = int.Parse(Console.ReadLine()!);
            Console.Write("Enter power : ");
            int power = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"{number} raise to power {power} = {Math.Pow(number, power)}");
        }

        // Question 9
        public static void Average()
        {
            Console.Write("Enter 1st Number : ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Enter 2nd Number : ");
            int b = int.Parse(Console.ReadLine()!);
            Console.Write("Enter 3rd Number : ");
            int c = int.Parse(Console.ReadLine()!);
            double average = (a + b + c) / 3.0;
            Console.WriteLine($"Average = {average}");
        }

        // Question 10
        public static void KmToMiles()
        {
            Console.Write("Enter Distance in Km : ");
            double km = double.Parse(Console.ReadLine()!);
            double miles = km * 0.621371;
            Console.WriteLine($"{km} Km = {miles} Miles");
        }
    }
}