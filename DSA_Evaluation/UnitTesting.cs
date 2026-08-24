using NUnit.Framework;

namespace DSA_Evaluation;

public class Tests
{
    private MetroSimulator metro;

    [SetUp]
    public void Setup()
    {
        metro = new MetroSimulator();

        metro.AddStation("D01", "Delhi", 100);
        metro.AddStation("A02", "Agra", 50);
        metro.AddStation("J03", "Jaipur", 250);
        metro.AddStation("C04", "Chandigarh", 110);
    }

    [Test]
    public void AddStation_ShouldSetCurrentStation()
    {
        Assert.That(metro.GetCurrentStation().Name, Is.EqualTo("Delhi"));
    }

    [Test]
    public void MoveForward_ShouldMoveToNextStation()
    {
        Assert.That(metro.MoveForward().Name, Is.EqualTo("Agra"));
    }

    [Test]
    public void MoveBackward_ShouldMoveToPreviousStation()
    {
        Assert.That(metro.MoveBackward().Name, Is.EqualTo("Chandigarh"));
    }

    [Test]
    public void MoveForward_ShouldWrapAround()
    {
        metro.MoveForward();
        metro.MoveForward();
        metro.MoveForward();

        Assert.That(metro.MoveForward().Name, Is.EqualTo("Delhi"));
    }

    [Test]
    public void ReverseDirection_ShouldChangeMovement()
    {
        metro.ReverseDirection();

        Assert.That(metro.MoveForward().Name, Is.EqualTo("Chandigarh"));
    }

    [Test]
    public void EmptyRoute_ShouldReturnNull()
    {
        MetroSimulator emptyMetro = new MetroSimulator();

        Assert.That(emptyMetro.GetCurrentStation(), Is.Null);
    }

    [Test]
    public void OneStation_ShouldPointToItself()
    {
        MetroSimulator singleMetro = new MetroSimulator();
        singleMetro.AddStation("D01", "Delhi", 100);

        Assert.That(singleMetro.MoveForward().Name, Is.EqualTo("Delhi"));
        Assert.That(singleMetro.MoveBackward().Name, Is.EqualTo("Delhi"));
    }

    [Test]
    public void PassengerQueue_ShouldFollowFIFO()
    {
        Passenger p1 = new Passenger("Prince");
        Passenger p2 = new Passenger("Rahul");

        metro.AddPassenger("D01", p1);
        metro.AddPassenger("D01", p2);

        Assert.That(metro.BoardPassenger("D01").Name, Is.EqualTo("Prince"));
        Assert.That(metro.BoardPassenger("D01").Name, Is.EqualTo("Rahul"));
    }

    [Test]
    public void EmptyQueue_ShouldReturnNull()
    {
        Assert.That(metro.BoardPassenger("D01"), Is.Null);
    }

    [Test]
    public void InvalidStation_ShouldNotAddPassenger()
    {
        Passenger passenger = new Passenger("Prince");

        Assert.That(metro.AddPassenger("XYZ", passenger), Is.False);
    }

    [Test]
    public void StationDictionary_ShouldFindStation()
    {
        Station station = metro.FindStation("D01");

        Assert.That(station, Is.Not.Null);
        Assert.That(station.Name, Is.EqualTo("Delhi"));
    }

    [Test]
    public void InvalidStationLookup_ShouldReturnNull()
    {
        Assert.That(metro.FindStation("XYZ"), Is.Null);
    }

    [Test]
    public void Sorting_ShouldSortStationsByDistance()
    {
        List<Station> stations = metro.SortStationsByDistance();

        Assert.That(stations[0].Name, Is.EqualTo("Agra"));
        Assert.That(stations[1].Name, Is.EqualTo("Delhi"));
        Assert.That(stations[2].Name, Is.EqualTo("Chandigarh"));
        Assert.That(stations[3].Name, Is.EqualTo("Jaipur"));
    }

    [Test]
    public void BinarySearch_ShouldFindFare()
    {
        metro.AddFare(100, 95);
        metro.AddFare(50, 60);
        metro.AddFare(250, 220);
        metro.AddFare(110, 100);

        metro.SortFareTable();

        Assert.That(metro.FindFare(100), Is.EqualTo(95));
    }

    [Test]
    public void BinarySearch_InvalidDistance_ShouldReturnMinusOne()
    {
        metro.AddFare(50, 60);
        metro.AddFare(100, 95);

        metro.SortFareTable();

        Assert.That(metro.FindFare(200), Is.EqualTo(-1));
    }

    [Test]
    public void Maintenance_ShouldAppendRecords()
    {
        metro.AppendMaintenance("D01", "Platform cleaning");
        metro.AppendMaintenance("A02", "Track repair");

        Assert.That(metro.GetMaintenanceCount(), Is.EqualTo(2));
    }

    // Integrated workflow 1
    [Test]
    public void BookingCancellationWorkflow_ShouldRestoreTicket()
    {
        Passenger passenger = new Passenger("Prince");

        bool booked = metro.BookTicket("T001", passenger, "D01", "A02", 50);

        Assert.That(booked, Is.True);
        Assert.That(metro.FindTicket("T001"), Is.Not.Null);

        bool cancelled = metro.CancelTicket("T001");

        Assert.That(cancelled, Is.True);
        Assert.That(metro.FindTicket("T001"), Is.Null);

        Booking restored = metro.UndoCancellation();

        Assert.That(restored, Is.Not.Null);
        Assert.That(restored.TicketId, Is.EqualTo("T001"));
        Assert.That(metro.FindTicket("T001"), Is.Not.Null);
    }

    // Integrated workflow 2
    [Test]
    public void PassengerFareWorkflow_ShouldWork()
    {
        Passenger passenger = new Passenger("Prince");

        Assert.That(metro.AddPassenger("D01", passenger), Is.True);
        Assert.That(metro.BoardPassenger("D01").Name, Is.EqualTo("Prince"));

        metro.AddFare(50, 60);
        metro.AddFare(100, 95);
        metro.SortFareTable();

        Assert.That(metro.FindFare(50), Is.EqualTo(60));
    }
}