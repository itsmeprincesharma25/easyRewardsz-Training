using System;

namespace Assignment
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
            int maths = 94, physics = 95, chemistry = 96;
            double avg = (maths + physics + chemistry) / 3.0;
            Console.WriteLine($"Sam's average mark in PCM is {avg:F2}");
        }

        // Question 3: Distance Conversion (Hardcoded)
        public static void KmToMilesHardcoded()
        {
            double km = 10.8;
            double miles = km / 1.6;
            Console.WriteLine($"The distance {km} km in miles is {miles}");
        }

        // Question 4: Profit and Loss
        public static void ProfitLoss()
        {
            double cp = 129, sp = 191;
            double profit = sp - cp;
            double profitPercent = (profit / cp) * 100;
            Console.WriteLine($"The Cost Price is INR {cp} and Selling Price is INR {sp}\nThe Profit is INR {profit} and the Profit Percentage is {profitPercent:F2}%");
        }

        // Question 5: Divide Pens
        public static void DividePens()
        {
            int pens = 14, students = 3;
            int perStudent = pens / students;
            int remaining = pens % students;
            Console.WriteLine($"The Pen Per Student is {perStudent} and the remaining pen not distributed is {remaining}");
        }

        // Question 6: Discounted Fee (Hardcoded)
        public static void DiscountedFee()
        {
            double fee = 125000, discountPercent = 10;
            double discount = (fee * discountPercent) / 100;
            double finalFee = fee - discount;
            Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {finalFee}");
        }

        // Question 7: Volume of Earth
        public static void VolumeOfEarth()
        {
            double rKm = 6378;
            double volKm = (4.0 / 3.0) * Math.PI * Math.Pow(rKm, 3);
            double rMiles = rKm / 1.6;
            double volMiles = (4.0 / 3.0) * Math.PI * Math.Pow(rMiles, 3);
            Console.WriteLine($"The volume of earth in cubic kilometers is {volKm:F2} and cubic miles is {volMiles:F2}");
        }

        // Question 8: Km to Miles (User Input)
        public static void KmToMiles()
        {
            Console.Write("Enter distance in Km: ");
            double km = double.Parse(Console.ReadLine()!);
            double miles = km / 1.6;
            Console.WriteLine($"The total miles is {miles} mile for the given {km} km");
        }

        // Question 9: Discounted Fee (User Input)
        public static void DiscountedFeeInput()
        {
            Console.Write("Enter Student Fee: ");
            double fee = double.Parse(Console.ReadLine()!);
            Console.Write("Enter Discount Percent: ");
            double discountPercent = double.Parse(Console.ReadLine()!);

            double discount = (fee * discountPercent) / 100;
            double finalFee = fee - discount;
            Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {finalFee}");
        }

        // Question 10: Height Conversion
        public static void HeightConversion()
        {
            Console.Write("Enter Height in cm: ");
            double cm = double.Parse(Console.ReadLine()!);

            double totalInches = cm / 2.54;
            int feet = (int)(totalInches / 12);
            double inches = totalInches % 12;

            Console.WriteLine($"Your Height in cm is {cm} while in feet is {feet} and inches is {inches:F2}");
        }

        // Question 11: Calculator
        public static void Calculator()
        {
            Console.Write("Enter 1st Number: ");
            double n1 = double.Parse(Console.ReadLine()!);
            Console.Write("Enter 2nd Number: ");
            double n2 = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"Addition: {n1 + n2}, Subtraction: {n1 - n2}, Multiplication: {n1 * n2}, Division: {n1 / n2}");
        }

        // Question 12: Area of Triangle
        public static void AreaOfTriangle()
        {
            Console.Write("Enter Base (in cm): ");
            double b = double.Parse(Console.ReadLine()!);
            Console.Write("Enter Height (in cm): ");
            double h = double.Parse(Console.ReadLine()!);

            double areaCm = 0.5 * b * h;
            double areaInches = areaCm / (2.54 * 2.54);

            Console.WriteLine($"Area of triangle in sq cm is {areaCm} and in sq inches is {areaInches:F2}");
        }

        // Question 13: Side of Square
        public static void SquareSide()
        {
            Console.Write("Enter Perimeter of Square: ");
            double perimeter = double.Parse(Console.ReadLine()!);

            double side = perimeter / 4.0;
            Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}");
        }

        // Question 14: Feet to Yards and Miles
        public static void DistanceConversion()
        {
            Console.Write("Enter Distance in Feet: ");
            double feet = double.Parse(Console.ReadLine()!);

            double yards = feet / 3.0;
            double miles = yards / 1760.0;

            Console.WriteLine($"Distance in yards is {yards:F2} and in miles is {miles:F4}");
        }

        // Question 15: Total Price
        public static void TotalPrice()
        {
            Console.Write("Enter Unit Price: ");
            double unitPrice = double.Parse(Console.ReadLine()!);
            Console.Write("Enter Quantity: ");
            int quantity = int.Parse(Console.ReadLine()!);

            double total = unitPrice * quantity;
            Console.WriteLine($"The total purchase price is INR {total} if the quantity is {quantity} and unit price is INR {unitPrice}");
        }

        // Question 16: Maximum Handshakes
        public static void Handshakes()
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine()!);

            int handshakes = (n * (n - 1)) / 2;
            Console.WriteLine($"Maximum number of handshakes among {n} students is {handshakes}");
        }
    }
}