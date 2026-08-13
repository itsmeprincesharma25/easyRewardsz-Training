using System;

namespace Assignment
{
    class Ticket
    {
        public int TicketId;
        public string CustomerName;
        public string MovieName;
        public int SeatNumber;
        public string BookingTime;

        public Ticket(int ticketId, string customerName, string movieName,
            int seatNumber, string bookingTime)
        {
            TicketId = ticketId;
            CustomerName = customerName;
            MovieName = movieName;
            SeatNumber = seatNumber;
            BookingTime = bookingTime;
        }
    }

    class TicketNode
    {
        public Ticket Data;
        public TicketNode Next;

        public TicketNode(Ticket ticket)
        {
            Data = ticket;
            Next = null;
        }
    }

    class TicketReservation
    {
        private TicketNode head;
        private TicketNode tail;
        private int count;

        public void AddTicket(Ticket ticket)
        {
            TicketNode newNode = new TicketNode(ticket);

            if (head == null)
            {
                head = tail = newNode;
                tail.Next = head;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
                tail.Next = head;
            }

            count++;
        }

        public void RemoveTicket(int ticketId)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available");
                return;
            }

            TicketNode current = head;
            TicketNode previous = tail;

            do
            {
                if (current.Data.TicketId == ticketId)
                {
                    if (current == head && current == tail)
                    {
                        head = null;
                        tail = null;
                    }
                    else
                    {
                        previous.Next = current.Next;

                        if (current == head)
                            head = current.Next;

                        if (current == tail)
                            tail = previous;

                        tail.Next = head;
                    }

                    count--;
                    Console.WriteLine("Ticket removed");
                    return;
                }

                previous = current;
                current = current.Next;

            } while (current != head);

            Console.WriteLine("Ticket not found");
        }

        public void DisplayTickets()
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked");
                return;
            }

            TicketNode current = head;

            do
            {
                DisplayTicket(current.Data);
                current = current.Next;

            } while (current != head);
        }

        public void SearchByCustomer(string customerName)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available");
                return;
            }

            TicketNode current = head;
            bool found = false;

            do
            {
                if (current.Data.CustomerName.Equals(
                    customerName, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayTicket(current.Data);
                    found = true;
                }

                current = current.Next;

            } while (current != head);

            if (!found)
                Console.WriteLine("Ticket not found");
        }

        public void SearchByMovie(string movieName)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available");
                return;
            }

            TicketNode current = head;
            bool found = false;

            do
            {
                if (current.Data.MovieName.Equals(
                    movieName, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayTicket(current.Data);
                    found = true;
                }

                current = current.Next;

            } while (current != head);

            if (!found)
                Console.WriteLine("Ticket not found");
        }

        public void CountTickets()
        {
            Console.WriteLine($"Total Booked Tickets : {count}");
        }

        private void DisplayTicket(Ticket ticket)
        {
            Console.WriteLine(
                $"Ticket: {ticket.TicketId} | " +
                $"Customer: {ticket.CustomerName} | " +
                $"Movie: {ticket.MovieName} | " +
                $"Seat: {ticket.SeatNumber} | " +
                $"Time: {ticket.BookingTime}"
            );
        }
    }
}