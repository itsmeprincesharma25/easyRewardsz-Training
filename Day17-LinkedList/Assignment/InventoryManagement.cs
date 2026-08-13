using System;

namespace Assignment
{
    class Item
    {
        public string Name;
        public int Id;
        public int Quantity;
        public double Price;

        public Item(string name, int id, int quantity, double price)
        {
            Name = name;
            Id = id;
            Quantity = quantity;
            Price = price;
        }
    }

    class Node
    {
        public Item Data;
        public Node Next;

        public Node(Item data)
        {
            Data = data;
            Next = null;
        }
    }

    class InventoryManagement
    {
        private Node head;

        public void AddAtBeginning(Item item)
        {
            Node newNode = new Node(item);
            newNode.Next = head;
            head = newNode;
        }

        public void AddAtEnd(Item item)
        {
            Node newNode = new Node(item);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public void AddAtPosition(Item item, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(item);
                return;
            }

            Node current = head;

            for (int i = 1; i < position - 1 && current != null; i++)
            {
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            Node newNode = new Node(item);
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void RemoveItem(int id)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (head.Data.Id == id)
            {
                head = head.Next;
                return;
            }

            Node current = head;

            while (current.Next != null)
            {
                if (current.Next.Data.Id == id)
                {
                    current.Next = current.Next.Next;
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("Item not found");
        }

        public void UpdateQuantity(int id, int quantity)
        {
            Node current = head;

            while (current != null)
            {
                if (current.Data.Id == id)
                {
                    current.Data.Quantity = quantity;
                    Console.WriteLine("Quantity updated");
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("Item not found");
        }

        public void SearchById(int id)
        {
            Node current = head;

            while (current != null)
            {
                if (current.Data.Id == id)
                {
                    DisplayItem(current.Data);
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("Item not found");
        }

        public void SearchByName(string name)
        {
            Node current = head;

            while (current != null)
            {
                if (current.Data.Name == name)
                {
                    DisplayItem(current.Data);
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("Item not found");
        }

        public void DisplayTotalValue()
        {
            double total = 0;
            Node current = head;

            while (current != null)
            {
                total += current.Data.Price * current.Data.Quantity;
                current = current.Next;
            }

            Console.WriteLine($"Total Inventory Value : ₹{total}");
        }

        public void SortByName(bool ascending)
        {
            if (head == null)
                return;

            for (Node i = head; i != null; i = i.Next)
            {
                for (Node j = i.Next; j != null; j = j.Next)
                {
                    bool condition = ascending
                        ? string.Compare(i.Data.Name, j.Data.Name) > 0
                        : string.Compare(i.Data.Name, j.Data.Name) < 0;

                    if (condition)
                    {
                        Item temp = i.Data;
                        i.Data = j.Data;
                        j.Data = temp;
                    }
                }
            }
        }

        public void SortByPrice(bool ascending)
        {
            if (head == null)
                return;

            for (Node i = head; i != null; i = i.Next)
            {
                for (Node j = i.Next; j != null; j = j.Next)
                {
                    bool condition = ascending
                        ? i.Data.Price > j.Data.Price
                        : i.Data.Price < j.Data.Price;

                    if (condition)
                    {
                        Item temp = i.Data;
                        i.Data = j.Data;
                        j.Data = temp;
                    }
                }
            }
        }

        public void DisplayItems()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node current = head;

            while (current != null)
            {
                DisplayItem(current.Data);
                current = current.Next;
            }
        }

        private void DisplayItem(Item item)
        {
            Console.WriteLine(
                $"{item.Id} - {item.Name} - Qty: {item.Quantity} - Price: ₹{item.Price}"
            );
        }
    }
}