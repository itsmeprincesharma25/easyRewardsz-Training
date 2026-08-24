# Circular Metro / Bus Route Simulator

## 1. Introduction

The Circular Metro / Bus Route Simulator is a C# project developed to simulate a circular transport system using different Data Structures and Algorithms.

The main purpose of this project is to integrate multiple data structures into one working simulator.

The simulator supports:

- Circular station navigation
- Forward and backward movement
- Direction reversal
- Passenger boarding queues
- Ticket booking and cancellation
- Undoing cancelled tickets
- Station maintenance records
- Station and ticket lookup
- Sorting stations by distance
- Fare lookup using Binary Search
- NUnit unit and integration testing

---

## 2. Objectives

The main objectives of the project are:

1. Implement a Circular Doubly Linked List for stations.
2. Support forward and backward station movement.
3. Support direction reversal.
4. Maintain FIFO passenger queues for each station.
5. Use a Stack for ticket cancellation and undo operations.
6. Maintain maintenance records using a Singly Linked List.
7. Use Dictionaries for station and ticket lookup.
8. Sort stations by distance using Merge Sort.
9. Search the fare table using Binary Search.
10. Test the important operations using NUnit.

---

## 3. Data Structures Used

| Data Structure / Algorithm | Purpose |
|---|---|
| Circular Doubly Linked List | Store and navigate stations |
| Queue | Passenger boarding at each station |
| Stack | Ticket cancellation and undo |
| Singly Linked List | Maintenance records |
| Dictionary | Station and ticket lookup |
| Merge Sort | Sort stations and fare table |
| Binary Search | Search fare by distance |
| List | Temporary storage during sorting |

---

## 4. Project Structure

```text
DSA_Evaluation
│
├── Models.cs
├── MetroSimulator.cs
├── Program.cs
├── Tests.cs
└── README.md