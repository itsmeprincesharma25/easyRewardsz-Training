# School Results Application

## Problem Statement

Design a School Results Application using UML diagrams.

### Classes
- Student
- Subject
- GradeCalculator

### Relationship
- A Student has multiple Subjects (Aggregation).
- GradeCalculator calculates the student's grade.

---

## Class Diagram

### Classes

Student
- studentId
- name
- grade
+ ViewResult()

Subject
- subjectName
- marks

GradeCalculator
+ CalculateGrade()

### Relationship

Student "1" <>----- "*" Subject
Student ---------> GradeCalculator

---

## Object Diagram

Student
Name : John

Subjects
- Maths : 90
- Science : 85

---

## Sequence Diagram

Student
    |
    | Request Grade
    v
GradeCalculator
    |
    | CalculateGrade()
    |
    v
Student
Display Result