using System;

class CalculateGCD
{
    static void Main(string[] args)
    {
        Console.Title = "Calculate the greatest common divisor";
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetWindowSize(80, 20);
        Console.Write("Enter number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        int b = int.Parse(Console.ReadLine());
        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                a -= b;
            }
            else
            {
                b -= a;
            }
        }
        Console.WriteLine("greatest common divisor of a and b is: " + Math.Max(a, b));
    }
}

