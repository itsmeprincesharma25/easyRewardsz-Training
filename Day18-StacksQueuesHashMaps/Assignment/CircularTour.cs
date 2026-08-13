using System;

namespace Assignment
{
    class PetrolPump
    {
        public int Petrol;
        public int Distance;

        public PetrolPump(int petrol, int distance)
        {
            Petrol = petrol;
            Distance = distance;
        }
    }

    class CircularTour
    {
        public int FindStartingPoint(PetrolPump[] pumps)
        {
            int start = 0;
            int petrol = 0;
            int total = 0;

            for (int i = 0; i < pumps.Length; i++)
            {
                int balance = pumps[i].Petrol - pumps[i].Distance;

                petrol += balance;
                total += balance;

                if (petrol < 0)
                {
                    start = i + 1;
                    petrol = 0;
                }
            }

            if (total >= 0)
                return start;

            return -1;
        }

        public void DisplayResult(int start)
        {
            if (start == -1)
                Console.WriteLine("Complete tour is not possible");
            else
                Console.WriteLine($"Starting Point : {start}");
        }
    }
}