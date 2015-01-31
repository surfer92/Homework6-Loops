/* Problem 10. Odd and Even Product
 * You are given n integers (given in a single line, separated by a space).
 * Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
 * Elements are counted from 1 to n, so the first element is odd, the second is even, etc. */

using System;

class OddOrEvenProduct
{
    static void Main(string[] args)
    {
        Console.Title = "Odd and Even Product";
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetWindowSize(80, 20);
        Console.WriteLine("Enter integers (in a single line, separated by a space): ");
        string integers = Console.ReadLine();
        string[] splitted = integers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int [splitted.Length];
        for (int i = 0; i < splitted.Length; i++)
        {
            numbers[i] = int.Parse(splitted[i]);
        }
        int odd = 1;
        int even = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 != 0)
            {
                even *= numbers[i];
            }
            else
            {
                odd *= numbers[i];
            }
        }
        if (odd == even)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Product = "+ even);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Even_Product = "+ even);
            Console.WriteLine("Odd_Product = "+ odd);
        }
    }
}

