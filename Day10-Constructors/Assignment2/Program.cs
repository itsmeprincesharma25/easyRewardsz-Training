using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Bank Account System ==========\n");

            BankAccountSystem account = new BankAccountSystem("Prince Sharma", "SBI1001");

            if (account is BankAccountSystem)
            {
                account.DisplayDetails();
            }

            BankAccountSystem.GetTotalAccounts();

            Console.WriteLine("\n========== Library Management ==========\n");

            LibraryManagement book = new LibraryManagement(
                "Atomic Habits",
                "James Clear",
                "ISBN001");

            if (book is LibraryManagement)
            {
                book.DisplayDetails();
            }

            LibraryManagement.DisplayLibraryName();

            Console.WriteLine("\n========== Employee Management ==========\n");

            EmployeeManagement employee =
                new EmployeeManagement("Prince Sharma", 101, "Software Engineer");

            if (employee is EmployeeManagement)
            {
                employee.DisplayDetails();
            }

            EmployeeManagement.DisplayTotalEmployees();

            Console.WriteLine("\n========== Shopping Cart ==========\n");

            ShoppingCart product =
                new ShoppingCart(201, "Laptop", 75000, 1);

            if (product is ShoppingCart)
            {
                product.DisplayDetails();
            }

            ShoppingCart.UpdateDiscount(15);

            Console.WriteLine("\nAfter Updating Discount:\n");
            product.DisplayDetails();

            Console.WriteLine("\n========== University Student ==========\n");

            UniversityStudent student =
                new UniversityStudent("Prince Sharma", 220101, "A");

            if (student is UniversityStudent)
            {
                student.DisplayDetails();
            }

            UniversityStudent.DisplayTotalStudents();

            Console.WriteLine("\n========== Vehicle Registration ==========\n");

            VehicleRegistration vehicle =
                new VehicleRegistration("Prince Sharma", "Car", "HR08AB1234");

            if (vehicle is VehicleRegistration)
            {
                vehicle.DisplayDetails();
            }

            VehicleRegistration.UpdateRegistrationFee(6500);

            Console.WriteLine("\nAfter Updating Registration Fee:\n");
            vehicle.DisplayDetails();

            Console.WriteLine("\n========== Hospital Management ==========\n");

            HospitalManagement patient =
                new HospitalManagement(501, "Prince Sharma", 21, "Fever");

            if (patient is HospitalManagement)
            {
                patient.DisplayDetails();
            }

            HospitalManagement.GetTotalPatients();
        }
    }
}