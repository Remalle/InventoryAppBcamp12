/*using System;
using System.Xml.Schema;

class Program
{
    static void Main()
    {
        bool exitRequested = false;

        while (!exitRequested)
        {
            Console.WriteLine("\nSimple Calculator");
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operator: +, -, /, * (or type 'exit' to quit)");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                exitRequested = true;
                continue;
            }

            char selectedOp = input[0];
            int total = Total(num1, num2, selectedOp);

            Console.WriteLine($"You entered: {num1} and {num2}");
            Console.WriteLine($"The result: {num1} {selectedOp} {num2} = {total}");
        }
    }

    static int Total(int a, int b, char op)
    {
        switch (op)
        {
            case '+':
                return a + b;
            case '-':
                return a - b;
            case '/':
                return a / b;
            case '*':
                return a * b;
            default:
                Console.WriteLine("Invalid operator. Try again.");
                return 0;
        }
    }
}*/