/* Problem 6. Calculate N! / K!
 * Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
 * Use only one loop */

using System;

class CalculateNK
{
    static void Main(string[] args)
    {
        Console.Title = "Calculate N! / K!";
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetWindowSize(80, 20);
        Console.Write("Write an integer: ");
        int n = Int32.Parse(Console.ReadLine());
        Console.Write("Write an integer: ");
        int k = Int32.Parse(Console.ReadLine());
        int result = 1;
        for (int i = n; i > k; i--)
        {
            result *= i;
        }
        Console.WriteLine(result);
    }
}

