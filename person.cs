public class Person
{
    public string Name { get; set; }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
    }
}