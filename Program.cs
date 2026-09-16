List<Student> students = new List<Student>();

Func<int, string> calculateGrade = (marks) =>
{
    if (marks >= 90)
    {
        return "A";
    }
    else if (marks >= 75)
    {
        return "B";
    }
    else if (marks >= 60)
    {
        return "C";
    }
    else
    {
        return "D";
    }
};

bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("==============================");
    Console.WriteLine("      STUDENT GRADE SYSTEM");
    Console.WriteLine("==============================");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Display Students");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":

            try
            {
                Console.Write("Enter Student ID: ");
                int studentId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Marks: ");
                int marks = Convert.ToInt32(Console.ReadLine());

                Student student = new Student(studentId, name, marks);

                students.Add(student);

                Console.WriteLine("Student added successfully!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numeric values.");
            }

            break;

        case "2":

            if (students.Count == 0)
            {
                Console.WriteLine("No students available.");
                break;
            }

            Console.WriteLine();
            Console.WriteLine("========= STUDENTS =========");

            foreach (Student student in students)
            {
                string grade = calculateGrade(student.Marks);

                student.DisplayDetails();
                Console.WriteLine($"Grade: {grade}");
                Console.WriteLine("----------------------------");
            }

            break;

        case "3":

            running = false;
            Console.WriteLine("Exiting Student Grade System...");
            break;

        default:

            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}