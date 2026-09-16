using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Student Grade Calculator ===");
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter marks (0 to 100): ");
        string marksInput = Console.ReadLine();

        int marks;
        bool isValid = int.TryParse(marksInput, out marks);

        if (isValid == false)
        {
            Console.WriteLine("Please enter a valid number for marks.");
            return;
        }

        if (marks < 0 || marks > 100)
        {
            Console.WriteLine("Marks must be between 0 and 100 only.");
            return;
        }

        string grade = "";

        if (marks >= 90)
        {
            grade = "A";
        }
        else if (marks >= 75)
        {
            grade = "B";
        }
        else if (marks >= 60)
        {
            grade = "C";
        }
        else
        {
            grade = "D";
        }

        Console.WriteLine("\n--- Result ---");
        Console.WriteLine("Student Name : " + name);
        Console.WriteLine("Marks Scored : " + marks);
        Console.WriteLine("Grade        : " + grade);
    }
}
