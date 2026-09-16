public class Student : Person
{
    public int StudentId { get; set; }

    private int _marks;

    public int Marks
    {
        get
        {
            return _marks;
        }

        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException(
                    "Marks must be between 0 and 100."
                );
            }

            _marks = value;
        }
    }

    public Student(int studentId, string name, int marks)
    {
        StudentId = studentId;
        Name = name;
        Marks = marks;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"ID: {StudentId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Marks: {Marks}");
    }
}