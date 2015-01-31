/* Problem 11. Random Numbers in Given Range
 * Write a program that enters 3 integers n, min and max (min != max)
 * and prints n random numbers in the range [min...max]. */

using System;

class RandomNumbersInGivenRange
{
    static void Main(string[] args)
    {
        Console.Title = "Random Numbers in given range";
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetWindowSize(80, 20);
        Console.WriteLine("Enter integer: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter min: ");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter max: ");
        int max = int.Parse(Console.ReadLine());
        Random ran = new Random();
        for (int i = 0; i < num; i++)
        {
            int number = ran.Next(min, max + 1);
            Console.Write(number + " ");
        }
        Console.WriteLine(" ");
    } 
}

