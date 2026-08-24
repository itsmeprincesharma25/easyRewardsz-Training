namespace DSA_Evaluation;

public class MetroSimulator
{
    private Station head;
    private Station tail;
    private Station current;

    private bool forward = true;

    private Stack<Booking> cancellationStack = new Stack<Booking>();
    private MaintenanceNode maintenanceHead;
    private MaintenanceNode maintenanceTail;

    private List<Fare> fareTable = new List<Fare>();

    // StationCode -> Station
    private Dictionary<string, Station> stationMap = new Dictionary<string, Station>();

    // TicketID -> Booking
    private Dictionary<string, Booking> ticketMap = new Dictionary<string, Booking>();

    // Route
    public void AddStation(string code, string name, double distance)
    {
        if (stationMap.ContainsKey(code))
            return;

        Station newStation = new Station(code, name, distance);

        if (head == null)
        {
            head = newStation;
            tail = newStation;
            current = newStation;

            head.Next = head;
            head.Prev = head;
        }
        else
        {
            newStation.Prev = tail;
            newStation.Next = head;

            tail.Next = newStation;
            head.Prev = newStation;

            tail = newStation;
        }

        stationMap.Add(code, newStation);
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("There is no route.");
            return;
        }

        Station temp = head;

        do
        {
            Console.Write($"{temp.Code} {temp.Name} -> ");
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine($"back to {head.Name}");
    }

    // Movement
    public Station MoveForward()
    {
        if (current == null)
            return null;

        current = forward ? current.Next : current.Prev;
        return current;
    }

    public Station MoveBackward()
    {
        if (current == null)
            return null;

        current = forward ? current.Prev : current.Next;
        return current;
    }

    public void ReverseDirection()
    {
        forward = !forward;
    }

    public Station GetCurrentStation()
    {
        return current;
    }

    // Station lookup
    public Station FindStation(string code)
    {
        if (code == null)
            return null;

        stationMap.TryGetValue(code, out Station station);
        return station;
    }

    // Passenger Queue
    public bool AddPassenger(string stationCode, Passenger passenger)
    {
        Station station = FindStation(stationCode);

        if (station == null || passenger == null)
            return false;

        station.BoardingQueue.Enqueue(passenger);
        return true;
    }

    public Passenger BoardPassenger(string stationCode)
    {
        Station station = FindStation(stationCode);

        if (station == null || station.BoardingQueue.Count == 0)
            return null;

        return station.BoardingQueue.Dequeue();
    }

    public int QueueSize(string stationCode)
    {
        Station station = FindStation(stationCode);

        if (station == null)
            return -1;

        return station.BoardingQueue.Count;
    }

    // Ticket Booking
    public bool BookTicket(string ticketId, Passenger passenger, string fromCode, string toCode, double fare)
    {
        if (ticketId == null || passenger == null)
            return false;

        if (ticketMap.ContainsKey(ticketId))
            return false;

        Station from = FindStation(fromCode);
        Station to = FindStation(toCode);

        if (from == null || to == null)
            return false;

        Booking booking = new Booking(ticketId, passenger, from, to, fare);
        ticketMap.Add(ticketId, booking);

        return true;
    }

    // Ticket lookup
    public Booking FindTicket(string ticketId)
    {
        if (ticketId == null)
            return null;

        ticketMap.TryGetValue(ticketId, out Booking booking);
        return booking;
    }

    // Ticket cancellation
    public bool CancelTicket(string ticketId)
    {
        if (ticketId == null)
            return false;

        if (!ticketMap.TryGetValue(ticketId, out Booking booking))
            return false;

        ticketMap.Remove(ticketId);
        cancellationStack.Push(booking);

        return true;
    }

    public Booking UndoCancellation()
    {
        if (cancellationStack.Count == 0)
            return null;

        // Last cancelled ticket is restored first.
        Booking booking = cancellationStack.Pop();

        ticketMap.Add(booking.TicketId, booking);

        return booking;
    }

    // Maintenance Log
    public void AppendMaintenance(string stationCode, string description)
    {
        if (FindStation(stationCode) == null)
            return;

        MaintenanceRecord record = new MaintenanceRecord(stationCode, description);
        MaintenanceNode newNode = new MaintenanceNode(record);

        if (maintenanceHead == null)
        {
            maintenanceHead = newNode;
            maintenanceTail = newNode;
            return;
        }

        maintenanceTail.Next = newNode;
        maintenanceTail = newNode;
    }

    public void DisplayMaintenance()
    {
        if (maintenanceHead == null)
        {
            Console.WriteLine("No maintenance records.");
            return;
        }

        MaintenanceNode temp = maintenanceHead;

        while (temp != null)
        {
            Console.WriteLine(temp.Data);
            temp = temp.Next;
        }
    }

    public int GetMaintenanceCount()
    {
        int count = 0;
        MaintenanceNode temp = maintenanceHead;

        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }

        return count;
    }

    // Sort stations by distance
    public List<Station> SortStationsByDistance()
    {
        List<Station> stations = new List<Station>();

        if (head == null)
            return stations;

        Station temp = head;

        do
        {
            stations.Add(temp);
            temp = temp.Next;
        } while (temp != head);

        MergeSort(stations, 0, stations.Count - 1);
        return stations;
    }

    private void MergeSort(List<Station> stations, int left, int right)
    {
        if (left >= right)
            return;

        int mid = left + (right - left) / 2;

        MergeSort(stations, left, mid);
        MergeSort(stations, mid + 1, right);

        Merge(stations, left, mid, right);
    }

    private void Merge(List<Station> stations, int left, int mid, int right)
    {
        List<Station> temp = new List<Station>();

        int i = left;
        int j = mid + 1;

        while (i <= mid && j <= right)
        {
            if (stations[i].Distance <= stations[j].Distance)
            {
                temp.Add(stations[i]);
                i++;
            }
            else
            {
                temp.Add(stations[j]);
                j++;
            }
        }

        while (i <= mid)
        {
            temp.Add(stations[i]);
            i++;
        }

        while (j <= right)
        {
            temp.Add(stations[j]);
            j++;
        }

        for (int k = 0; k < temp.Count; k++)
            stations[left + k] = temp[k];
    }

    public void DisplaySortedStations()
    {
        List<Station> stations = SortStationsByDistance();

        foreach (Station station in stations)
            Console.WriteLine($"{station.Code} - {station.Name} - {station.Distance} km");
    }

    // Fare table
    public void AddFare(double distance, double price)
    {
        fareTable.Add(new Fare(distance, price));
    }

    public void SortFareTable()
    {
        MergeSortFare(fareTable, 0, fareTable.Count - 1);
    }

    private void MergeSortFare(List<Fare> fares, int left, int right)
    {
        if (left >= right)
            return;

        int mid = left + (right - left) / 2;

        MergeSortFare(fares, left, mid);
        MergeSortFare(fares, mid + 1, right);

        MergeFare(fares, left, mid, right);
    }

    private void MergeFare(List<Fare> fares, int left, int mid, int right)
    {
        List<Fare> temp = new List<Fare>();

        int i = left;
        int j = mid + 1;

        while (i <= mid && j <= right)
        {
            if (fares[i].Distance <= fares[j].Distance)
            {
                temp.Add(fares[i]);
                i++;
            }
            else
            {
                temp.Add(fares[j]);
                j++;
            }
        }

        while (i <= mid)
        {
            temp.Add(fares[i]);
            i++;
        }

        while (j <= right)
        {
            temp.Add(fares[j]);
            j++;
        }

        for (int k = 0; k < temp.Count; k++)
            fares[left + k] = temp[k];
    }

    // Binary Search
    public double FindFare(double distance)
    {
        int left = 0;
        int right = fareTable.Count - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (fareTable[mid].Distance == distance)
                return fareTable[mid].Price;

            if (fareTable[mid].Distance < distance)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
}