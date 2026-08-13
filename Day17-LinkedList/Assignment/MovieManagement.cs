using System;

namespace Assignment
{
    class Movie
    {
        public string Title;
        public string Director;
        public int Year;
        public double Rating;

        public Movie(string title, string director, int year, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
        }
    }

    class MovieNode
    {
        public Movie Data;
        public MovieNode Next;
        public MovieNode Prev;

        public MovieNode(Movie data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }

    class MovieManagement
    {
        private MovieNode head;
        private MovieNode tail;

        // Add at beginning
        public void AddAtBeginning(Movie movie)
        {
            MovieNode newNode = new MovieNode(movie);

            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }

        // Add at end
        public void AddAtEnd(Movie movie)
        {
            MovieNode newNode = new MovieNode(movie);

            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }

        // Add at position
        public void AddAtPosition(Movie movie, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(movie);
                return;
            }

            MovieNode current = head;

            for (int i = 1; i < position - 1 && current != null; i++)
            {
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            if (current == tail)
            {
                AddAtEnd(movie);
                return;
            }

            MovieNode newNode = new MovieNode(movie);

            newNode.Next = current.Next;
            newNode.Prev = current;

            current.Next.Prev = newNode;
            current.Next = newNode;
        }

        public void RemoveMovie(string title)
        {
            MovieNode current = head;

            while (current != null)
            {
                if (current.Data.Title == title)
                {
                    if (current.Prev != null)
                        current.Prev.Next = current.Next;
                    else
                        head = current.Next;

                    if (current.Next != null)
                        current.Next.Prev = current.Prev;
                    else
                        tail = current.Prev;

                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("Movie not found");
        }

        public void SearchByDirector(string director)
        {
            MovieNode current = head;

            while (current != null)
            {
                if (current.Data.Director == director)
                {
                    DisplayMovie(current.Data);
                }

                current = current.Next;
            }
        }

        public void SearchByRating(double rating)
        {
            MovieNode current = head;

            while (current != null)
            {
                if (current.Data.Rating == rating)
                {
                    DisplayMovie(current.Data);
                }

                current = current.Next;
            }
        }

        public void DisplayForward()
        {
            MovieNode current = head;

            while (current != null)
            {
                DisplayMovie(current.Data);
                current = current.Next;
            }
        }

        public void DisplayReverse()
        {
            MovieNode current = tail;

            while (current != null)
            {
                DisplayMovie(current.Data);
                current = current.Prev;
            }
        }

        public void UpdateRating(string title, double rating)
        {
            MovieNode current = head;

            while (current != null)
            {
                if (current.Data.Title == title)
                {
                    current.Data.Rating = rating;
                    Console.WriteLine("Rating updated");
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("Movie not found");
        }

        private void DisplayMovie(Movie movie)
        {
            Console.WriteLine(
                $"{movie.Title} - {movie.Director} - {movie.Year} - {movie.Rating}"
            );
        }
    }
}