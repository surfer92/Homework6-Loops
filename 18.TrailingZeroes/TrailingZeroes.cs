﻿/* Problem 18.* Trailing Zeroes in N!

    Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
    Your program should work well for very big numbers, e.g. n=100000. */


using System;

class TrailingZeroes
{
    static void Main(string[] args)
    {
        Console.Title = "Trailing Zeroes in N!";
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetWindowSize(80, 20);
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        int trailingZeroes = 0;
        int divisor = 5;
        while (n / divisor >= 1)
        {
            trailingZeroes += n / divisor;
            divisor *= 5;
        }
        Console.WriteLine("The trailing zeroes are: " + trailingZeroes);
    }
}

