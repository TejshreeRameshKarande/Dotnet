using System;

class ArithmeticOperations
{
    static void Main()
    {
        int a, b;

        Console.WriteLine("Enter first number:");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Modulus: " + (a % b));
    }
}