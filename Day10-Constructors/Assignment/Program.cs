using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Constructors ==========\n");

            Book book = new Book("The Alchemist", "Paulo Coelho");
            book.DisplayDetails();

            Console.WriteLine();

            Circle circle = new Circle(7);
            circle.DisplayDetails();

            Console.WriteLine();

            Person person1 = new Person("Prince", 21);
            Person person2 = new Person(person1);
            person2.DisplayDetails();

            Console.WriteLine();

            HotelBooking booking = new HotelBooking("Prince", "Deluxe", 3);
            booking.DisplayDetails();

            Console.WriteLine();

            LibraryBook libraryBook = new LibraryBook("Atomic Habits", "James Clear", 599);
            libraryBook.DisplayDetails();
            libraryBook.BorrowBook();

            Console.WriteLine();

            CarRental rental = new CarRental("Prince", "Honda City", 5);
            rental.DisplayDetails();

            Console.WriteLine("\n========== Instance vs Class Variables ==========\n");

            Product product1 = new Product("Laptop", 75000);
            Product product2 = new Product("Mouse", 1200);

            product1.DisplayProductDetails();
            Console.WriteLine();
            product2.DisplayProductDetails();
            Console.WriteLine();

            Product.DisplayTotalProducts();

            Console.WriteLine();

            Course course = new Course("C#", 30, 5000);
            course.DisplayCourseDetails();

            Console.WriteLine();

            Course.UpdateInstituteName("EasyRewardsz");
            course.DisplayCourseDetails();

            Console.WriteLine();

            Vehicle vehicle = new Vehicle("Prince", "Car");
            vehicle.DisplayVehicleDetails();

            Console.WriteLine();

            Vehicle.UpdateRegistrationFee(6500);
            vehicle.DisplayVehicleDetails();

            Console.WriteLine("\n========== Access Modifiers ==========\n");

            PostgraduateStudent student = new PostgraduateStudent(101, "Prince", 9.2);
            student.DisplayDetails();

            Console.WriteLine();

            EBook ebook = new EBook("978-12345", "C# Programming", "John Smith");
            ebook.DisplayDetails();

            Console.WriteLine();

            SavingsAccount account = new SavingsAccount("ACC1001", "Prince", 50000);
            account.DisplayDetails();

            Console.WriteLine();

            Manager manager = new Manager(501, "IT", 85000);
            manager.DisplayDetails();
        }
    }
}