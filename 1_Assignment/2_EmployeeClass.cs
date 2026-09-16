using System;


class Employee
{
    public int EmployeeId;
    public string Name;
    public string Department;
    public double Salary;

    public Employee(int empId, string name, string dept, double salary)
    {
        EmployeeId = empId;
        Name = name;
        Department = dept;
        Salary = salary;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Employee ID  : " + EmployeeId);
        Console.WriteLine("Name         : " + Name);
        Console.WriteLine("Department   : " + Department);
        Console.WriteLine("Salary       : " + Salary);
        Console.WriteLine("------------------------");
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Employee(1, "Suresh", "IT", 45000);
        Employee e2 = new Employee(2, "Meena", "HR", 38000);
        Employee e3 = new Employee(3, "Ravi", "Finance", 52000);

        Console.WriteLine("===== Employee List =====");
        e1.DisplayInfo();
        e2.DisplayInfo();
        e3.DisplayInfo();
    }
}
