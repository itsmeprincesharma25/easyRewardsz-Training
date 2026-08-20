using System;

namespace Assignment
{
    class InterestCalculation
    {
        public double CalculateInterest(double amount, double rate, int years)
        {
            // Amount and rate cannot be negative
            if (amount < 0 || rate < 0)
            {
                throw new ArgumentException(
                    "Amount and rate must be positive");
            }

            return (amount * rate * years) / 100;
        }

        public void Run()
        {
            try
            {
                Console.Write("Enter amount: ");
                double amount = double.Parse(Console.ReadLine());

                Console.Write("Enter rate: ");
                double rate = double.Parse(Console.ReadLine());

                Console.Write("Enter years: ");
                int years = int.Parse(Console.ReadLine());

                double interest = CalculateInterest(
                    amount, rate, years);

                Console.WriteLine($"Interest: {interest}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Invalid input: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid numbers");
            }
        }
    }
}