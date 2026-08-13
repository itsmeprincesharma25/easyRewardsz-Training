using System;

namespace Assignment
{
    class Task
    {
        public int TaskId;
        public string TaskName;
        public int Priority;
        public string DueDate;

        public Task(int taskId, string taskName, int priority, string dueDate)
        {
            TaskId = taskId;
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
        }
    }

    class TaskNode
    {
        public Task Data;
        public TaskNode Next;

        public TaskNode(Task data)
        {
            Data = data;
            Next = null;
        }
    }

    class TaskScheduler
    {
        private TaskNode head;
        private TaskNode tail;
        private TaskNode current;

        // Add at beginning
        public void AddAtBeginning(Task task)
        {
            TaskNode newNode = new TaskNode(task);

            if (head == null)
            {
                head = tail = newNode;
                newNode.Next = head;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
                tail.Next = head;
            }
        }

        // Add at end
        public void AddAtEnd(Task task)
        {
            TaskNode newNode = new TaskNode(task);

            if (head == null)
            {
                head = tail = newNode;
                newNode.Next = head;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
                tail.Next = head;
            }
        }

        // Add at position
        public void AddAtPosition(Task task, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(task);
                return;
            }

            if (head == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            TaskNode currentNode = head;

            for (int i = 1; i < position - 1; i++)
            {
                currentNode = currentNode.Next;

                if (currentNode == head)
                {
                    Console.WriteLine("Invalid position");
                    return;
                }
            }

            TaskNode newNode = new TaskNode(task);
            newNode.Next = currentNode.Next;
            currentNode.Next = newNode;

            if (currentNode == tail)
                tail = newNode;
        }

        public void RemoveTask(int taskId)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            TaskNode currentNode = head;
            TaskNode previous = tail;

            do
            {
                if (currentNode.Data.TaskId == taskId)
                {
                    if (currentNode == head)
                        head = head.Next;

                    if (currentNode == tail)
                        tail = previous;

                    previous.Next = currentNode.Next;
                    tail.Next = head;

                    if (current == currentNode)
                        current = head;

                    return;
                }

                previous = currentNode;
                currentNode = currentNode.Next;

            } while (currentNode != head);

            Console.WriteLine("Task not found");
        }

        public void ViewCurrentTask()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            if (current == null)
                current = head;

            DisplayTask(current.Data);
        }

        public void MoveToNextTask()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            if (current == null)
                current = head;
            else
                current = current.Next;

            DisplayTask(current.Data);
        }

        public void DisplayTasks()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            TaskNode currentNode = head;

            do
            {
                DisplayTask(currentNode.Data);
                currentNode = currentNode.Next;

            } while (currentNode != head);
        }

        public void SearchByPriority(int priority)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            TaskNode currentNode = head;
            bool found = false;

            do
            {
                if (currentNode.Data.Priority == priority)
                {
                    DisplayTask(currentNode.Data);
                    found = true;
                }

                currentNode = currentNode.Next;

            } while (currentNode != head);

            if (!found)
                Console.WriteLine("Task not found");
        }

        private void DisplayTask(Task task)
        {
            Console.WriteLine(
                $"{task.TaskId} - {task.TaskName} - Priority: {task.Priority} - Due: {task.DueDate}"
            );
        }
    }
}