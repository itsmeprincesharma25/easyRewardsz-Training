# Grocery Store Bill Generation Application

## Problem Statement

Design a Grocery Store Bill Generation Application using UML diagrams.

### Classes
- Customer
- Product
- BillGenerator

### Relationship
- A Customer purchases multiple Products (Composition).
- BillGenerator calculates the total bill for the Customer.

---

## Class Diagram

### Classes

Customer
- customerId
- customerName

Product
- productName
- quantity
- price

BillGenerator
+ GenerateBill()

### Relationship

Customer "1" *----- "*" Product
Customer ---------> BillGenerator

---

## Object Diagram

Customer
Name : Alice

Products
- Apples (2 kg @ $3/kg)
- Milk (1 L @ $2/L)

---

## Sequence Diagram

Customer
    |
    | Checkout
    v
BillGenerator
    |
    | GenerateBill()
    |
    v
Customer
Display Total Bill