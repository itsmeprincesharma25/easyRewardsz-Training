namespace DSA_Evaluation;

public class Station
{
    public string Code { get; set; }
    public string Name { get; set; }
    public double Distance { get; set; }
    public Station Next { get; set; }
    public Station Prev { get; set; }

    public Queue<Passenger> BoardingQueue { get; set; }

    public Station(string code, string name, double distance)
    {
        Code = code;
        Name = name;
        Distance = distance;
        BoardingQueue = new Queue<Passenger>();
    }
}

public class Passenger
{
    public string Name { get; set; }

    public Passenger(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}

public class Booking
{
    public string TicketId { get; set; }
    public Passenger Passenger { get; set; }
    public Station From { get; set; }
    public Station To { get; set; }
    public double Fare { get; set; }

    public Booking(string ticketId, Passenger passenger, Station from, Station to, double fare)
    {
        TicketId = ticketId;
        Passenger = passenger;
        From = from;
        To = to;
        Fare = fare;
    }

    public override string ToString()
    {
        return $"{TicketId} | {Passenger.Name} | {From.Name} -> {To.Name} | ₹{Fare}";
    }
}

public class MaintenanceRecord
{
    public string StationCode { get; set; }
    public string Description { get; set; }

    public MaintenanceRecord(string stationCode, string description)
    {
        StationCode = stationCode;
        Description = description;
    }

    public override string ToString()
    {
        return $"{StationCode} - {Description}";
    }
}

public class MaintenanceNode
{
    public MaintenanceRecord Data { get; set; }
    public MaintenanceNode Next { get; set; }
    public MaintenanceNode(MaintenanceRecord data)
    {
        Data = data;
    }
}

public class Fare
{
    public double Distance { get; set; }
    public double Price { get; set; }
    public Fare(double distance, double price)
    {
        Distance = distance;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Distance} km - ₹{Price}";
    }
}