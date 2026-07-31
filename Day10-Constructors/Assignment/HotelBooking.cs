using System;

namespace Assignment
{
    class HotelBooking
    {
        private string guestName;
        private string roomType;
        private int nights;

        // Default constructor
        public HotelBooking()
        {
            guestName = "Guest";
            roomType = "Standard";
            nights = 1;
        }

        // Parameterized constructor
        public HotelBooking(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }

        // Copy constructor
        public HotelBooking(HotelBooking booking)
        {
            guestName = booking.guestName;
            roomType = booking.roomType;
            nights = booking.nights;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Guest Name : {guestName}");
            Console.WriteLine($"Room Type  : {roomType}");
            Console.WriteLine($"Nights     : {nights}");
        }
    }
}