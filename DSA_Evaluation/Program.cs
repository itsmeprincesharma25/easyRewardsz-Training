namespace DSA_Evaluation;

public class Program
{
    public static void Main()
    {
        MetroSimulator metro = new MetroSimulator();

        metro.AddStation("D01", "Delhi", 100);
        metro.AddStation("A02", "Agra", 50);
        metro.AddStation("J03", "Jaipur", 250);
        metro.AddStation("C04", "Chandigarh", 110);

        Console.WriteLine("ROUTE");
        metro.Display();

        Console.WriteLine("\nMOVEMENT");
        Console.WriteLine("Current: " + metro.GetCurrentStation().Name);
        Console.WriteLine("Forward: " + metro.MoveForward().Name);
        Console.WriteLine("Forward: " + metro.MoveForward().Name);
        Console.WriteLine("Backward: " + metro.MoveBackward().Name);

        metro.ReverseDirection();
        Console.WriteLine("Direction reversed");
        Console.WriteLine("Move: " + metro.MoveForward().Name);

        Console.WriteLine("\nQUEUE");

        Passenger p1 = new Passenger("Prince");
        Passenger p2 = new Passenger("Rahul");

        metro.AddPassenger("D01", p1);
        metro.AddPassenger("D01", p2);

        Console.WriteLine("Boarded: " + metro.BoardPassenger("D01"));
        Console.WriteLine("Boarded: " + metro.BoardPassenger("D01"));

        Console.WriteLine("\nBOOKING & CANCELLATION");

        bool booked = metro.BookTicket("T001", p1, "D01", "A02", 50);
        Console.WriteLine("Ticket booked: " + booked);
        Console.WriteLine("Ticket found: " + metro.FindTicket("T001"));

        bool cancelled = metro.CancelTicket("T001");
        Console.WriteLine("Ticket cancelled: " + cancelled);

        Booking restored = metro.UndoCancellation();
        Console.WriteLine("Restored: " + restored);

        Console.WriteLine("\nMAINTENANCE");

        metro.AppendMaintenance("D01", "Platform cleaning");
        metro.AppendMaintenance("A02", "Track repair");
        metro.AppendMaintenance("J03", "Escalator maintenance");

        metro.DisplayMaintenance();

        Console.WriteLine("\nSORTED STATIONS");
        metro.DisplaySortedStations();

        Console.WriteLine("\nFARE TABLE");

        metro.AddFare(100, 95);
        metro.AddFare(50, 60);
        metro.AddFare(250, 220);
        metro.AddFare(110, 100);

        metro.SortFareTable();

        Console.WriteLine($"Fare for 100 km: ₹{metro.FindFare(100)}");
    }
}