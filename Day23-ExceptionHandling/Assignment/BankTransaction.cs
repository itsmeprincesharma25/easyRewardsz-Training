using System;

namespace Assignment
{
    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
    }

    class BankTransaction
    {
        private double balance;

        public BankTransaction(double balance)
        {
            this.balance = balance;
        }

        public void Withdraw(double amount)
        {
            // Withdrawal amount cannot be negative
            if (amount < 0)
            {
                throw new ArgumentException("Invalid amount!");
            }

            // Check whether enough balance is available
            if (amount > balance)
            {
                throw new InsufficientFundsException(
                    "Insufficient balance!");
            }

            balance -= amount;

            Console.WriteLine(
                $"Withdrawal successful, new balance: {balance}");
        }

        public void Run()
        {
            try
            {
                Console.Write("Enter withdrawal amount: ");
                double amount = double.Parse(Console.ReadLine());

                Withdraw(amount);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid amount");
            }
        }
    }
}