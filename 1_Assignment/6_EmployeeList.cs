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
}

class Program
{
    static void Main()
    {
        List<Employee> empList = new List<Employee>();

        empList.Add(new Employee(1, "Rohit Sharma", "IT", 50000));
        empList.Add(new Employee(2, "Sunita Verma", "HR", 42000));
        empList.Add(new Employee(3, "Karan Singh", "Finance", 60000));
        empList.Add(new Employee(4, "Neha Gupta", "Marketing", 38000));
        empList.Add(new Employee(5, "Vijay Kumar", "IT", 55000));

        Console.WriteLine("======= Employee List =======");
        Console.WriteLine();

        for (int i = 0; i < empList.Count; i++)
        {
            Employee e = empList[i];
            Console.WriteLine("Employee ID  : " + e.EmployeeId);
            Console.WriteLine("Name         : " + e.Name);
            Console.WriteLine("Department   : " + e.Department);
            Console.WriteLine("Salary       : Rs." + e.Salary);
            Console.WriteLine("-----------------------------");
        }

        Console.WriteLine("Total Employees: " + empList.Count);
    }
}
