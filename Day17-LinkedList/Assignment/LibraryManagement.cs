using System;

namespace Assignment
{
    class Book
    {
        public string Title;
        public string Author;
        public string Genre;
        public int Id;
        public bool Available;

        public Book(string title, string author, string genre, int id, bool available)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Id = id;
            Available = available;
        }
    }

    class BookNode
    {
        public Book Data;
        public BookNode Next;
        public BookNode Prev;

        public BookNode(Book data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }

    class LibraryManagement
    {
        private BookNode head;
        private BookNode tail;

        public void AddAtBeginning(Book book)
        {
            BookNode newNode = new BookNode(book);

            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }

        public void AddAtEnd(Book book)
        {
            BookNode newNode = new BookNode(book);

            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }

        public void AddAtPosition(Book book, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(book);
                return;
            }

            BookNode current = head;

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
                AddAtEnd(book);
                return;
            }

            BookNode newNode = new BookNode(book);

            newNode.Next = current.Next;
            newNode.Prev = current;

            current.Next.Prev = newNode;
            current.Next = newNode;
        }

        public void RemoveBook(int id)
        {
            BookNode current = head;

            while (current != null)
            {
                if (current.Data.Id == id)
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

            Console.WriteLine("Book not found");
        }

        public void SearchByTitle(string title)
        {
            BookNode current = head;

            while (current != null)
            {
                if (current.Data.Title == title)
                {
                    DisplayBook(current.Data);
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("Book not found");
        }

        public void SearchByAuthor(string author)
        {
            BookNode current = head;

            while (current != null)
            {
                if (current.Data.Author == author)
                {
                    DisplayBook(current.Data);
                }

                current = current.Next;
            }
        }

        public void UpdateAvailability(int id, bool available)
        {
            BookNode current = head;

            while (current != null)
            {
                if (current.Data.Id == id)
                {
                    current.Data.Available = available;
                    Console.WriteLine("Availability updated");
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("Book not found");
        }

        public void DisplayForward()
        {
            BookNode current = head;

            while (current != null)
            {
                DisplayBook(current.Data);
                current = current.Next;
            }
        }

        public void DisplayReverse()
        {
            BookNode current = tail;

            while (current != null)
            {
                DisplayBook(current.Data);
                current = current.Prev;
            }
        }

        public void CountBooks()
        {
            int count = 0;
            BookNode current = head;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            Console.WriteLine($"Total Books : {count}");
        }

        private void DisplayBook(Book book)
        {
            Console.WriteLine(
                $"{book.Id} - {book.Title} - {book.Author} - {book.Genre} - Available: {book.Available}"
            );
        }
    }
}