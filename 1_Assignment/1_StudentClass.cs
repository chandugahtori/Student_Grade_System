using System;


class Student
{
    public int StudentId;
    public string Name;
    public int Age;


    public Student(int id, string name, int age)
    {
        StudentId = id;
        Name = name;
        Age = age;
    }

    public void ShowDetails()
    {
        Console.WriteLine("Student ID: " + StudentId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("--------------------");
    }
}

class Program
{
    static void Main()
    {

        Student s1 = new Student(101, "Rahul", 20);
        Student s2 = new Student(102, "Priya", 21);
        Student s3 = new Student(103, "Amit", 19);

        Console.WriteLine("=== Student Details ===");
        s1.ShowDetails();
        s2.ShowDetails();
        s3.ShowDetails();
    }
}
