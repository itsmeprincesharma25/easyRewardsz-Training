using System;
using System.Collections.Generic;

namespace Assignment
{
    class User
    {
        public int UserId;
        public string Name;
        public int Age;
        public List<int> Friends;

        public User(int userId, string name, int age)
        {
            UserId = userId;
            Name = name;
            Age = age;
            Friends = new List<int>();
        }
    }

    class UserNode
    {
        public User Data;
        public UserNode Next;

        public UserNode(User user)
        {
            Data = user;
            Next = null;
        }
    }

    class SocialMediaFriends
    {
        private UserNode head;

        public void AddUser(User user)
        {
            UserNode newNode = new UserNode(user);

            if (head == null)
            {
                head = newNode;
                return;
            }

            UserNode current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public void AddFriend(int userId, int friendId)
        {
            User user = FindUser(userId);
            User friend = FindUser(friendId);

            if (user == null || friend == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            if (!user.Friends.Contains(friendId))
                user.Friends.Add(friendId);

            if (!friend.Friends.Contains(userId))
                friend.Friends.Add(userId);
        }

        public void RemoveFriend(int userId, int friendId)
        {
            User user = FindUser(userId);
            User friend = FindUser(friendId);

            if (user == null || friend == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            user.Friends.Remove(friendId);
            friend.Friends.Remove(userId);
        }

        public void DisplayFriends(int userId)
        {
            User user = FindUser(userId);

            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            Console.WriteLine($"Friends of {user.Name}:");

            foreach (int friendId in user.Friends)
            {
                User friend = FindUser(friendId);

                if (friend != null)
                    Console.WriteLine($"{friend.UserId} - {friend.Name}");
            }
        }

        public void FindMutualFriends(int userId1, int userId2)
        {
            User user1 = FindUser(userId1);
            User user2 = FindUser(userId2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            Console.WriteLine("Mutual Friends:");

            foreach (int friendId in user1.Friends)
            {
                if (user2.Friends.Contains(friendId))
                {
                    User friend = FindUser(friendId);

                    if (friend != null)
                        Console.WriteLine($"{friend.UserId} - {friend.Name}");
                }
            }
        }

        public void SearchUser(string name)
        {
            UserNode current = head;

            while (current != null)
            {
                if (current.Data.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayUser(current.Data);
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("User not found");
        }

        public void SearchUser(int userId)
        {
            User user = FindUser(userId);

            if (user != null)
                DisplayUser(user);
            else
                Console.WriteLine("User not found");
        }

        public void CountFriends(int userId)
        {
            User user = FindUser(userId);

            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            Console.WriteLine($"{user.Name} has {user.Friends.Count} friends.");
        }

        private User FindUser(int userId)
        {
            UserNode current = head;

            while (current != null)
            {
                if (current.Data.UserId == userId)
                    return current.Data;

                current = current.Next;
            }

            return null;
        }

        private void DisplayUser(User user)
        {
            Console.WriteLine($"ID   : {user.UserId}");
            Console.WriteLine($"Name : {user.Name}");
            Console.WriteLine($"Age  : {user.Age}");
        }
    }
}