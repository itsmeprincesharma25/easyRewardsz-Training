using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Record Management\n");

            StudentRecord students = new StudentRecord();

            students.AddAtEnd(new Student(1, "Prince", 22, 'A'));
            students.AddAtEnd(new Student(2, "Rahul", 21, 'B'));
            students.AddAtBeginning(new Student(3, "Aman", 23, 'A'));

            students.DisplayStudents();

            Console.WriteLine("\nSearch Student:");
            students.SearchStudent(2);

            Console.WriteLine("\nUpdate Grade:");
            students.UpdateGrade(2, 'A');

            Console.WriteLine("\nAfter Update:");
            students.DisplayStudents();


            Console.WriteLine("\nMovie Management\n");

            MovieManagement movies = new MovieManagement();

            movies.AddAtEnd(new Movie("Inception", "Christopher Nolan", 2010, 8.8));
            movies.AddAtEnd(new Movie("Interstellar", "Christopher Nolan", 2014, 8.6));
            movies.AddAtBeginning(new Movie("Avatar", "James Cameron", 2009, 8.0));

            Console.WriteLine("Forward:");
            movies.DisplayForward();

            Console.WriteLine("\nReverse:");
            movies.DisplayReverse();

            Console.WriteLine("\nSearch by Director:");
            movies.SearchByDirector("Christopher Nolan");


            Console.WriteLine("\nTask Scheduler\n");

            TaskScheduler tasks = new TaskScheduler();

            tasks.AddAtEnd(new Task(1, "Study C#", 1, "15-Aug"));
            tasks.AddAtEnd(new Task(2, "Practice LinkedList", 2, "16-Aug"));
            tasks.AddAtBeginning(new Task(3, "Complete Assignment", 1, "14-Aug"));

            Console.WriteLine("Tasks:");
            tasks.DisplayTasks();

            Console.WriteLine("\nCurrent Task:");
            tasks.ViewCurrentTask();

            Console.WriteLine("\nNext Task:");
            tasks.MoveToNextTask();


            Console.WriteLine("\nInventory Management\n");

            InventoryManagement inventory = new InventoryManagement();

            inventory.AddAtEnd(new Item("Laptop", 101, 5, 50000));
            inventory.AddAtEnd(new Item("Mouse", 102, 10, 800));
            inventory.AddAtBeginning(new Item("Keyboard", 103, 7, 1500));

            inventory.DisplayItems();

            Console.WriteLine();
            inventory.DisplayTotalValue();

            Console.WriteLine("\nSearch Item:");
            inventory.SearchById(102);

            Console.WriteLine("\nLibrary Management\n");

            LibraryManagement library = new LibraryManagement();

            library.AddAtEnd(new Book(
                "Atomic Habits",
                "James Clear",
                "Self Help",
                1,
                true));

            library.AddAtEnd(new Book(
                "Harry Potter",
                "J.K. Rowling",
                "Fantasy",
                2,
                true));

            library.AddAtBeginning(new Book(
                "The Alchemist",
                "Paulo Coelho",
                "Fiction",
                3,
                false));

            Console.WriteLine("Forward:");
            library.DisplayForward();

            Console.WriteLine("\nReverse:");
            library.DisplayReverse();

            Console.WriteLine("\nBook Count:");
            library.CountBooks();


            Console.WriteLine("\nRound Robin Scheduling\n");

            RoundRobinScheduling scheduler = new RoundRobinScheduling();

            Process p1 = new Process(1, 5, 1);
            Process p2 = new Process(2, 7, 2);
            Process p3 = new Process(3, 4, 1);

            scheduler.AddProcess(p1);
            scheduler.AddProcess(p2);
            scheduler.AddProcess(p3);

            Console.WriteLine("Processes:");
            scheduler.DisplayProcesses();

            Console.WriteLine("\nScheduling:");
            scheduler.Schedule(2);

            Process[] processes = { p1, p2, p3 };

            Console.WriteLine("\nAverage Times:");
            scheduler.DisplayAverageTimes(processes);


            Console.WriteLine("\nSocial Media Friends\n");

            SocialMediaFriends social = new SocialMediaFriends();

            social.AddUser(new User(1, "Prince", 22));
            social.AddUser(new User(2, "Rahul", 21));
            social.AddUser(new User(3, "Aman", 23));

            social.AddFriend(1, 2);
            social.AddFriend(1, 3);
            social.AddFriend(2, 3);

            Console.WriteLine("Prince's Friends:");
            social.DisplayFriends(1);

            Console.WriteLine("\nMutual Friends:");
            social.FindMutualFriends(1, 2);

            Console.WriteLine("\nFriend Count:");
            social.CountFriends(1);


            Console.WriteLine("\nText Editor Undo Redo\n");

            TextEditorUndoRedo editor = new TextEditorUndoRedo();

            editor.AddState("Hello");
            editor.AddState("Hello World");
            editor.AddState("Hello World!");

            editor.DisplayCurrentState();

            Console.WriteLine("\nUndo:");
            editor.Undo();
            editor.DisplayCurrentState();

            Console.WriteLine("\nRedo:");
            editor.Redo();
            editor.DisplayCurrentState();


            Console.WriteLine("\nTicket Reservation\n");

            TicketReservation tickets = new TicketReservation();

            tickets.AddTicket(new Ticket(
                101,
                "Prince",
                "Inception",
                10,
                "10:30 AM"));

            tickets.AddTicket(new Ticket(
                102,
                "Rahul",
                "Avatar",
                11,
                "11:00 AM"));

            tickets.AddTicket(new Ticket(
                103,
                "Aman",
                "Inception",
                12,
                "11:30 AM"));

            Console.WriteLine("Booked Tickets:");
            tickets.DisplayTickets();

            Console.WriteLine("\nSearch by Movie:");
            tickets.SearchByMovie("Inception");

            Console.WriteLine();
            tickets.CountTickets();
        }
    }
}