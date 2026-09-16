using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Simple Calculator ===");
        Console.WriteLine("Operations: + - * /");
        Console.WriteLine();

        double num1, num2;
        string op;

        Console.Write("Enter first number: ");
        string input1 = Console.ReadLine();

        bool check1 = double.TryParse(input1, out num1);
        if (check1 == false)
        {
            Console.WriteLine("Invalid number entered.");
            return;
        }

        Console.Write("Enter operator (+, -, *, /): ");
        op = Console.ReadLine();

        Console.Write("Enter second number: ");
        string input2 = Console.ReadLine();

        bool check2 = double.TryParse(input2, out num2);
        if (check2 == false)
        {
            Console.WriteLine("Invalid number entered.");
            return;
        }

        double result = 0;

        if (op == "+")
        {
            result = num1 + num2;
            Console.WriteLine("Answer: " + result);
        }
        else if (op == "-")
        {
            result = num1 - num2;
            Console.WriteLine("Answer: " + result);
        }
        else if (op == "*")
        {
            result = num1 * num2;
            Console.WriteLine("Answer: " + result);
        }
        else if (op == "/")
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
            }
            else
            {
                result = num1 / num2;
                Console.WriteLine("Answer: " + result);
            }
        }
        else
        {
            Console.WriteLine("Wrong operator. Please use +, -, *, /");
        }
    }
}
