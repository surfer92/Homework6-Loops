/* Problem 13. Binary to Decimal Number
 * Using loops write a program that converts a binary integer number to its decimal form.
 * The input is entered as string. The output should be a variable of type long.
 * Do not use the built-in .NET functionality.*/

using System;

class BinaryToDecimalNumber
{
    static void Main(string[] args)
    {
        Console.Title = "Translate what your PC is saying to you";
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetWindowSize(80, 20);
        Console.Write("Enter binary: ");
        string number = Console.ReadLine();
        int todecimal = 0;
        for (int i = 0; i < number.Length; i++)
        {
            todecimal += int.Parse(number[i].ToString()) * (int)Math.Pow(2, number.Length -1 - i);
        }
        Console.WriteLine("Decimal number is = " + todecimal);
    }
}

