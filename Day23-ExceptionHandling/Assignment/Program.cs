using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. File Not Found Handling\n");

            FileNotFoundHandling file = new FileNotFoundHandling();
            file.ReadFile("data.txt");


            Console.WriteLine("\n2. Division and Input Errors\n");

            DivisionInputHandling division = new DivisionInputHandling();
            division.Divide();


            Console.WriteLine("\n3. Custom Exception\n");

            CustomException age = new CustomException();
            age.Run();


            Console.WriteLine("\n4. Multiple Exceptions\n");

            MultipleExceptions multiple = new MultipleExceptions();

            int[] numbers = { 10, 20, 30, 40 };

            multiple.GetValue(numbers, 2);


            Console.WriteLine("\n5. Using Statement\n");

            UsingFileHandling usingFile = new UsingFileHandling();
            usingFile.ReadFirstLine("info.txt");


            Console.WriteLine("\n6. Interest Calculation\n");

            InterestCalculation interest = new InterestCalculation();
            interest.Run();


            Console.WriteLine("\n7. Finally Block\n");

            FinallyDemo finallyDemo = new FinallyDemo();
            finallyDemo.Divide();


            Console.WriteLine("\n8. Exception Propagation\n");

            ExceptionPropagation propagation = new ExceptionPropagation();
            propagation.Run();


            Console.WriteLine("\n9. Nested Try-Catch\n");

            NestedTryCatch nested = new NestedTryCatch();

            int[] values = { 100, 200, 300 };

            nested.Calculate(values, 1, 10);


            Console.WriteLine("\n10. Bank Transaction\n");

            BankTransaction bank = new BankTransaction(10000);
            bank.Run();
        }
    }
}