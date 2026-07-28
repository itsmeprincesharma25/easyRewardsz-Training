using System;

namespace Assignments
{
    public class Assignment2
    {
        // Question 1: Harry's Age
        public static void HarryAge()
        {
            int birthYear = 2000;
            int currentYear = 2024;
            int age = currentYear - birthYear;

            Console.WriteLine($"Harry's age in {currentYear} is {age}");
        }

        // Question 2: Sam's PCM Average
        public static void SamAverage()
        {
            int maths = 94;
            int physics = 95;
            int chemistry = 96;

            double avg = (maths + physics + chemistry) / 3.0;

            Console.WriteLine($"Sam's average marks in PCM is {avg:F2}");
        }

        // Question 3: Kilometers to Miles Conversion
        public static void KmToMilesHardcoded()
        {
            double km = 10.8;
            double miles = km / 1.6;

            Console.WriteLine($"{km} km = {miles:F2} miles");
        }

        // Question 4: Profit and Loss
        public static void ProfitLoss()
        {
            double cp = 129;
            double sp = 191;

            double profit = sp - cp;
            double profitPercent = (profit / cp) * 100;

            Console.WriteLine($"Cost Price        : ₹{cp}");
            Console.WriteLine($"Selling Price     : ₹{sp}");
            Console.WriteLine($"Profit            : ₹{profit}");
            Console.WriteLine($"Profit Percentage : {profitPercent:F2}%");
        }

        // Question 5: Divide Pens Among Students
        public static void DividePens()
        {
            int pens = 14;
            int students = 3;

            int perStudent = pens / students;
            int remaining = pens % students;

            Console.WriteLine($"Pens per student : {perStudent}");
            Console.WriteLine($"Remaining pens   : {remaining}");
        }

        // Question 6: Discounted Fee
        public static void DiscountedFee()
        {
            double fee = 125000;
            double discountPercent = 10;

            double discount = (fee * discountPercent) / 100;
            double finalFee = fee - discount;

            Console.WriteLine($"Discount Amount : ₹{discount:F2}");
            Console.WriteLine($"Final Fee       : ₹{finalFee:F2}");
        }

        // Question 7: Volume of Earth
        public static void VolumeOfEarth()
        {
            double rKm = 6378;

            double volKm = (4.0 / 3.0) * Math.PI * Math.Pow(rKm, 3);

            double rMiles = rKm / 1.6;
            double volMiles = (4.0 / 3.0) * Math.PI * Math.Pow(rMiles, 3);

            Console.WriteLine($"Volume in cubic kilometers : {volKm:F2}");
            Console.WriteLine($"Volume in cubic miles      : {volMiles:F2}");
        }

        // Question 8: Kilometers to Miles Conversion
        public static void KmToMiles()
        {
            Console.Write("Enter distance in km: ");
            double km = double.Parse(Console.ReadLine()!);

            double miles = km / 1.6;

            Console.WriteLine($"{km} km = {miles:F2} miles");
        }        // Question 9: Discounted Fee
        public static void DiscountedFeeInput()
        {
            Console.Write("Enter student fee: ");
            double fee = double.Parse(Console.ReadLine()!);

            Console.Write("Enter discount percentage: ");
            double discountPercent = double.Parse(Console.ReadLine()!);

            double discount = (fee * discountPercent) / 100;
            double finalFee = fee - discount;

            Console.WriteLine($"Discount Amount : ₹{discount:F2}");
            Console.WriteLine($"Final Fee       : ₹{finalFee:F2}");
        }

        // Question 10: Height Conversion
        public static void HeightConversion()
        {
            Console.Write("Enter height in cm: ");
            double cm = double.Parse(Console.ReadLine()!);

            double totalInches = cm / 2.54;
            int feet = (int)(totalInches / 12);
            double inches = totalInches % 12;

            Console.WriteLine($"Height = {feet} feet {inches:F2} inches");
        }

        // Question 11: Calculator
        public static void Calculator()
        {
            Console.Write("Enter first number: ");
            double n1 = double.Parse(Console.ReadLine()!);

            Console.Write("Enter second number: ");
            double n2 = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"Addition       : {n1 + n2}");
            Console.WriteLine($"Subtraction    : {n1 - n2}");
            Console.WriteLine($"Multiplication : {n1 * n2}");
            Console.WriteLine($"Division       : {n1 / n2}");
        }

        // Question 12: Area of Triangle
        public static void AreaOfTriangle()
        {
            Console.Write("Enter base (in cm): ");
            double b = double.Parse(Console.ReadLine()!);

            Console.Write("Enter height (in cm): ");
            double h = double.Parse(Console.ReadLine()!);

            double areaCm = 0.5 * b * h;
            double areaInches = areaCm / (2.54 * 2.54);

            Console.WriteLine($"Area in square centimeters : {areaCm:F2}");
            Console.WriteLine($"Area in square inches      : {areaInches:F2}");
        }

        // Question 13: Side of Square
        public static void SquareSide()
        {
            Console.Write("Enter perimeter of square: ");
            double perimeter = double.Parse(Console.ReadLine()!);

            double side = perimeter / 4;

            Console.WriteLine($"Side of square = {side}");
        }

        // Question 14: Feet to Yards and Miles Conversion
        public static void DistanceConversion()
        {
            Console.Write("Enter distance in feet: ");
            double feet = double.Parse(Console.ReadLine()!);

            double yards = feet / 3;
            double miles = yards / 1760;

            Console.WriteLine($"Distance in yards : {yards:F2}");
            Console.WriteLine($"Distance in miles : {miles:F4}");
        }

        // Question 15: Total Purchase Price
        public static void TotalPrice()
        {
            Console.Write("Enter unit price: ");
            double unitPrice = double.Parse(Console.ReadLine()!);

            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine()!);

            double total = unitPrice * quantity;

            Console.WriteLine($"Total Purchase Price = ₹{total:F2}");
        }

        // Question 16: Maximum Handshakes
        public static void Handshakes()
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine()!);

            int handshakes = (n * (n - 1)) / 2;

            Console.WriteLine($"Maximum handshakes = {handshakes}");
        }
    }
}