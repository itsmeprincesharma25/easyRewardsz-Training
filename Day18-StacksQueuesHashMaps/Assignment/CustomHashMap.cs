using System;

namespace Assignment
{
    class HashNode
    {
        public int Key;
        public string Value;
        public HashNode Next;

        public HashNode(int key, string value)
        {
            Key = key;
            Value = value;
        }
    }

    class CustomHashMap
    {
        private HashNode[] buckets;
        private int size;

        public CustomHashMap(int size)
        {
            this.size = size;
            buckets = new HashNode[size];
        }

        private int GetIndex(int key)
        {
            return Math.Abs(key) % size;
        }

        public void Insert(int key, string value)
        {
            int index = GetIndex(key);
            HashNode current = buckets[index];

            while (current != null)
            {
                if (current.Key == key)
                {
                    current.Value = value;
                    return;
                }

                current = current.Next;
            }

            HashNode newNode = new HashNode(key, value);
            newNode.Next = buckets[index];
            buckets[index] = newNode;
        }

        public string Get(int key)
        {
            int index = GetIndex(key);
            HashNode current = buckets[index];

            while (current != null)
            {
                if (current.Key == key)
                    return current.Value;

                current = current.Next;
            }

            return null;
        }

        public void Delete(int key)
        {
            int index = GetIndex(key);
            HashNode current = buckets[index];
            HashNode previous = null;

            while (current != null)
            {
                if (current.Key == key)
                {
                    if (previous == null)
                        buckets[index] = current.Next;
                    else
                        previous.Next = current.Next;

                    return;
                }

                previous = current;
                current = current.Next;
            }

            Console.WriteLine("Key not found");
        }
    }
}