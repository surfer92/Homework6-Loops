/* Problem 1. Numbers from 1 to N
 * Write a program that enters from the console
 * a positive integer n and prints all the numbers from
 * 1 to n, on a single line, separated by a space */

using System;

class NumbersFrom1ToN
{
    static void Main(string[] args)
    {
        Console.Title = "Numbers from 1 to N";
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetWindowSize(80, 10);
        Console.Write("Enter positive integer: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            Console.Write(" " + i);
        }
        Console.WriteLine("\n");
    }
}

