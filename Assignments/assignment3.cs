using System;

namespace Assignment
{
    public class Assignment3
    {
        // Question 1: Quotient and Remainder
        public static void QuotientAndRemainder()
        {
            Console.Write("Enter 1st Number: ");
            int n1 = int.Parse(Console.ReadLine()!);
            Console.Write("Enter 2nd Number: ");
            int n2 = int.Parse(Console.ReadLine()!);

            int quotient = n1 / n2;
            int remainder = n1 % n2;

            Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {n1} and {n2}");
        }

        // Question 2: Int Operations
        public static void IntOperation()
        {
            Console.Write("Enter value for a: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Enter value for b: ");
            int b = int.Parse(Console.ReadLine()!);
            Console.Write("Enter value for c: ");
            int c = int.Parse(Console.ReadLine()!);

            int op1 = a + b * c;
            int op2 = a * b + c;
            int op3 = c + a / b;
            int op4 = a % b + c;

            Console.WriteLine($"The results of Int Operations are {op1}, {op2}, {op3}, and {op4}");
        }

        // Question 3: Double Operations
        public static void DoubleOpt()
        {
            Console.Write("Enter value for a: ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write("Enter value for b: ");
            double b = double.Parse(Console.ReadLine()!);
            Console.Write("Enter value for c: ");
            double c = double.Parse(Console.ReadLine()!);

            double op1 = a + b * c;
            double op2 = a * b + c;
            double op3 = c + a / b;
            double op4 = a % b + c;

            Console.WriteLine($"The results of Double Operations are {op1}, {op2}, {op3}, and {op4}");
        }

        // Question 4: Celsius to Fahrenheit Conversion
        public static void C2F()
        {
            Console.Write("Enter Temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine()!);

            double fahrenheit = (celsius * 9.0 / 5.0) + 32;

            Console.WriteLine($"The Celsius is {celsius} and Fahrenheit is {fahrenheit}");
        }

        // Question 5: Fahrenheit to Celsius Conversion
        public static void F2C()
        {
            Console.Write("Enter Temperature in Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine()!);

            double celsius = (fahrenheit - 32) * 5.0 / 9.0;

            Console.WriteLine($"The Fahrenheit is {fahrenheit} and Celsius is {celsius}");
        }

        // Question 6: Calculate Total Income
        public static void TotalIncome()
        {
            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine()!);
            Console.Write("Enter Bonus: ");
            double bonus = double.Parse(Console.ReadLine()!);

            double totalIncome = salary + bonus;

            Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalIncome}");
        }

        // Question 7: Swap Two Numbers
        public static void SwapNumbers()
        {
            Console.Write("Enter 1st Number: ");
            int n1 = int.Parse(Console.ReadLine()!);
            Console.Write("Enter 2nd Number: ");
            int n2 = int.Parse(Console.ReadLine()!);

            int temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine($"The swapped numbers are {n1} and {n2}");
        }

        // Question 8: Eric Travels with User Input
        public static void TravelDetails()
        {
            Console.Write("Enter Traveler Name: ");
            string name = Console.ReadLine()!;
            Console.Write("Enter From City: ");
            string fromCity = Console.ReadLine()!;
            Console.Write("Enter Via City: ");
            string viaCity = Console.ReadLine()!;
            Console.Write("Enter To City: ");
            string toCity = Console.ReadLine()!;

            Console.Write($"Enter distance from {fromCity} to {viaCity} (in miles/km): ");
            double fromToVia = double.Parse(Console.ReadLine()!);
            Console.Write($"Enter distance from {viaCity} to {toCity} (in miles/km): ");
            double viaToFinalCity = double.Parse(Console.ReadLine()!);

            Console.Write($"Enter time taken from {fromCity} to {viaCity} (in minutes): ");
            int time1 = int.Parse(Console.ReadLine()!);
            Console.Write($"Enter time taken from {viaCity} to {toCity} (in minutes): ");
            int time2 = int.Parse(Console.ReadLine()!);

            double totalDistance = fromToVia + viaToFinalCity;
            int totalTime = time1 + time2;

            Console.WriteLine($"The results of the trip are: Total Distance travelled by {name} from {fromCity} to {toCity} via {viaCity} is {totalDistance} and Total Time taken is {totalTime} minutes");
        }

        // Question 9: Athlete Triangular Park Rounds
        public static void AthleteRounds()
        {
            Console.Write("Enter Side 1 (in meters): ");
            double side1 = double.Parse(Console.ReadLine()!);
            Console.Write("Enter Side 2 (in meters): ");
            double side2 = double.Parse(Console.ReadLine()!);
            Console.Write("Enter Side 3 (in meters): ");
            double side3 = double.Parse(Console.ReadLine()!);

            double perimeter = side1 + side2 + side3;
            double distanceInMeters = 5000; // 5 km = 5000 meters
            double rounds = distanceInMeters / perimeter;

            Console.WriteLine($"The total number of rounds the athlete will run is {rounds:F2} to complete 5 km");
        }

        // Question 10: Divide Chocolates
        public static void DivideChocolates()
        {
            Console.Write("Enter total number of chocolates: ");
            int Chocolates = int.Parse(Console.ReadLine()!);
            Console.Write("Enter number of children: ");
            int Children = int.Parse(Console.ReadLine()!);

            int chocolatesPerChild = Chocolates / Children;
            int remainingChocolates = Chocolates % Children;

            Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild} and the number of remaining chocolates is {remainingChocolates}");
        }

        // Question 11: Calculate Simple Interest
        public static void CalculateSimpleInterest()
        {
            Console.Write("Enter Principal amount: ");
            double principal = double.Parse(Console.ReadLine()!);
            Console.Write("Enter Rate of Interest: ");
            double rate = double.Parse(Console.ReadLine()!);
            Console.Write("Enter Time: ");
            double time = double.Parse(Console.ReadLine()!);

            double simpleInterest = (principal * rate * time) / 100;

            Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate} and Time {time}");
        }

        // Question 12: Convert Pounds to Kilograms
        public static void PoundsToKilograms()
        {
            Console.Write("Enter weight in pounds: ");
            double Pounds = double.Parse(Console.ReadLine()!);

            double Kg = Pounds / 2.2;

            Console.WriteLine($"The weight of the person in pounds is {Pounds} and in kg is {Kg:F2}");
        }
    }
}