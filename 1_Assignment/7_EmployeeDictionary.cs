using System;
using System.Collections.Generic;



class Employee
{
    public int EmployeeId;
    public string Name;
    public string Department;
    public double Salary;

    public Employee(int id, string name, string dept, double salary)
    {
        EmployeeId = id;
        Name = name;
        Department = dept;
        Salary = salary;
    }

    public void ShowDetails()
    {
        Console.WriteLine("Employee ID  : " + EmployeeId);
        Console.WriteLine("Name         : " + Name);
        Console.WriteLine("Department   : " + Department);
        Console.WriteLine("Salary       : Rs." + Salary);
    }
}

class Program
{
    static void Main()
    {
        Dictionary<int, Employee> empDict = new Dictionary<int, Employee>();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n====== Employee System ======");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Search Employee by ID");
            Console.WriteLine("3. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter Employee ID: ");
                string idInput = Console.ReadLine();
                int empId;

                bool isNum = int.TryParse(idInput, out empId);
                if (isNum == false)
                {
                    Console.WriteLine("Please enter valid Employee ID.");
                    continue;
                }

                if (empDict.ContainsKey(empId))
                {
                    Console.WriteLine("Employee with this ID already exists.");
                    continue;
                }

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Department: ");
                string dept = Console.ReadLine();

                Console.Write("Enter Salary: ");
                string salInput = Console.ReadLine();
                double salary;

                bool isSal = double.TryParse(salInput, out salary);
                if (isSal == false)
                {
                    Console.WriteLine("Invalid salary entered.");
                    continue;
                }

                Employee newEmp = new Employee(empId, name, dept, salary);
                empDict.Add(empId, newEmp);
                Console.WriteLine("Employee added successfully!");
            }
            else if (choice == "2")
            {
                Console.Write("Enter Employee ID to search: ");
                string searchId = Console.ReadLine();
                int searchEmpId;

                bool isNum = int.TryParse(searchId, out searchEmpId);
                if (isNum == false)
                {
                    Console.WriteLine("Please enter a valid ID.");
                    continue;
                }

                if (empDict.ContainsKey(searchEmpId))
                {
                    Console.WriteLine("\n--- Employee Found ---");
                    empDict[searchEmpId].ShowDetails();
                }
                else
                {
                    Console.WriteLine("No employee found with ID: " + searchEmpId);
                }
            }
            else if (choice == "3")
            {
                Console.WriteLine("Exiting program...");
                running = false;
            }
            else
            {
                Console.WriteLine("Wrong choice. Please enter 1, 2 or 3.");
            }
        }
    }
}
