/* Problem 12.* Randomize the Numbers 1…N
 * Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.*/

using System;

class RandomizeTheNumbers1toN
{
    static void Main(string[] args)
    {
        Console.Title = "Random Numbers ";
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetWindowSize(80, 20);
        Console.Write("Enter integer: ");
        int num = int.Parse(Console.ReadLine());
        Random ran = new Random(1);
        for (int i = 0; i < num; i++)
        {
            int random = ran.Next(num);
            Console.Write(" "+ random);
        }
        Console.WriteLine();
    }
}

