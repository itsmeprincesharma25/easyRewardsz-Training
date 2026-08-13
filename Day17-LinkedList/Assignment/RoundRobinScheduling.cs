using System;

namespace Assignment
{
    class Process
    {
        public int ProcessId;
        public int BurstTime;
        public int Priority;
        public int RemainingTime;
        public int WaitingTime;
        public int TurnaroundTime;

        public Process(int processId, int burstTime, int priority)
        {
            ProcessId = processId;
            BurstTime = burstTime;
            Priority = priority;
            RemainingTime = burstTime;
        }
    }

    class ProcessNode
    {
        public Process Data;
        public ProcessNode Next;

        public ProcessNode(Process process)
        {
            Data = process;
            Next = null;
        }
    }

    class RoundRobinScheduling
    {
        private ProcessNode head;
        private ProcessNode tail;

        public void AddProcess(Process process)
        {
            ProcessNode newNode = new ProcessNode(process);

            if (head == null)
            {
                head = tail = newNode;
                tail.Next = head;
                return;
            }

            tail.Next = newNode;
            tail = newNode;
            tail.Next = head;
        }

        public void RemoveProcess(int processId)
        {
            if (head == null)
                return;

            ProcessNode current = head;
            ProcessNode previous = tail;

            do
            {
                if (current.Data.ProcessId == processId)
                {
                    if (current == head)
                        head = head.Next;

                    if (current == tail)
                        tail = previous;

                    previous.Next = current.Next;
                    tail.Next = head;

                    if (head == current)
                        head = null;

                    return;
                }

                previous = current;
                current = current.Next;

            } while (current != head);
        }

        public void Schedule(int timeQuantum)
        {
            if (head == null)
            {
                Console.WriteLine("No processes available");
                return;
            }

            ProcessNode current = head;
            int currentTime = 0;

            while (head != null)
            {
                int time = Math.Min(timeQuantum, current.Data.RemainingTime);

                current.Data.RemainingTime -= time;
                currentTime += time;

                if (current.Data.RemainingTime == 0)
                {
                    current.Data.TurnaroundTime = currentTime;
                    current.Data.WaitingTime =
                        current.Data.TurnaroundTime - current.Data.BurstTime;

                    int completedId = current.Data.ProcessId;
                    ProcessNode next = current.Next;

                    RemoveProcess(completedId);

                    if (head == null)
                        break;

                    current = next == current ? head : next;
                }
                else
                {
                    current = current.Next;
                }

                DisplayProcesses();
                Console.WriteLine();
            }
        }

        public void DisplayProcesses()
        {
            if (head == null)
            {
                Console.WriteLine("No processes available");
                return;
            }

            ProcessNode current = head;

            do
            {
                Console.WriteLine(
                    $"P{current.Data.ProcessId} - Burst: {current.Data.BurstTime} - Priority: {current.Data.Priority} - Remaining: {current.Data.RemainingTime}"
                );

                current = current.Next;

            } while (current != head);
        }

        public void DisplayAverageTimes(Process[] processes)
        {
            double totalWaiting = 0;
            double totalTurnaround = 0;

            foreach (Process process in processes)
            {
                totalWaiting += process.WaitingTime;
                totalTurnaround += process.TurnaroundTime;
            }

            Console.WriteLine($"Average Waiting Time : {totalWaiting / processes.Length}");
            Console.WriteLine($"Average Turnaround Time : {totalTurnaround / processes.Length}");
        }
    }
}