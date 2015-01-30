/* Problem 2. Numbers Not Divisible by 3 and 7
 * Write a program that enters from the console a positive
 * integer n and prints all the numbers from 1 to n
 * not divisible by 3 and 7, on a single line, separated by a space. */


using System;

class NumbersNotDivisibleBy3and7
{
    static void Main(string[] args)
    {
        Console.Title = "Numbers Not Divisible by 3 and 7";
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetWindowSize(80, 10);
        Console.WriteLine("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i <= number; i++)
        {
            if ((i % 3 == 0) || (i % 7 == 0))
            {
                Console.Write("");
            }
            else
            {
                Console.Write(" " + i);
            }
        }
        Console.WriteLine("\n");
    }
}

