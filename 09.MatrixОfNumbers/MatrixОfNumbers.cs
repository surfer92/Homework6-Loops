/* Problem 9. Matrix of Numbers
 * Write a program that reads from the console a positive integer
 * number n (1 ≤ n ≤ 20) and prints a matrix like in the examples
 * below. Use two nested loops. */


using System;

class MatrixОfNumbers
{
    static void Main(string[] args)
    {
        Console.Title = "Matrix of Numbers";
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetWindowSize(60, 20);
        Console.WriteLine("Enter a number [1-20]");
        int n = int.Parse(Console.ReadLine());
        if (n > 0 && n <= 20)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int coll = 0; coll < n; coll++)
                {
                    Console.Write("{0,2} ", coll + row);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("The number must be bigger than 0 and lesser than 21");
        }
    }
}

