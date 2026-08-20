using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Assignment
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }

    class Serialization
    {
        public void SaveEmployees(string fileName, List<Employee> employees)
        {
            try
            {
                string json = JsonSerializer.Serialize(employees);

                // Save employee data into the file
                File.WriteAllText(fileName, json);

                Console.WriteLine("Employees saved successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
        }

        public void LoadEmployees(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    Console.WriteLine("File does not exist.");
                    return;
                }

                string json = File.ReadAllText(fileName);

                // Convert file data back into employee objects
                List<Employee> employees =
                    JsonSerializer.Deserialize<List<Employee>>(json);

                Console.WriteLine("Employees:");

                foreach (Employee employee in employees)
                {
                    Console.WriteLine(
                        $"{employee.Id} - {employee.Name} - " +
                        $"{employee.Department} - {employee.Salary}"
                    );
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
        }
    }
}