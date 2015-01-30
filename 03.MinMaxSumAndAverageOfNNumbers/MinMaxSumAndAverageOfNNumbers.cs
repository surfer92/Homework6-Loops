/* Problem 3. Min, Max, Sum and Average of N Numbers
 * Write a program that reads from the console a sequence of n integer
 * numbers and returns the minimal, the maximal number, the sum and the average of all numbers
 * (displayed with 2 digits after the decimal point).
 * The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
 * The output is like in the examples below. */

using System;
using System.Linq; //to use array max/min
class MinMaxSumAndAverageOfNNumbers
{
    static void Main(string[] args)
    {
        Console.Title = "Min, Max, Sum and Average of N Numbers";
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetWindowSize(80, 10);
        Console.Write("Enter the number of integers: ");
        int numbers = int.Parse(Console.ReadLine());
        int[] arr = new int[numbers];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter integer: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        int min = arr.Max();
        int max = arr.Max();
        int sum = arr.Sum();
        double avg = arr.Average();
        Console.WriteLine("\nmin= {0} \nmax= {1} \nsum= {2} \navg= {3}",min ,max ,sum ,avg);
    }
}

