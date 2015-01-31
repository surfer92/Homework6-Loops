﻿/*Problem 7. Calculate N! / (K! * (N-K)!)
* In combinatorics, the number of ways to choose
* k different members out of a group of n different elements
* (also known as the number of combinations)
* is calculated by the following formula: N! / K!(N-K)!
* For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
* Your task is to write a program that calculates n! / (k! * (n-k)!)
* for given n and k (1 < k < n < 100). Try to use only two loops. */

using System;
using System.Numerics;
class CalculateCombinatorics
{
    static void Main()
    {
        Console.Title = "Calculate N! / (K! * (N-K)!)";
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetWindowSize(80, 20);
        Console.Write("Enter value of N > 1  : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value of K<n<100  : ");
        int k = int.Parse(Console.ReadLine());
        BigInteger fact1 = 1;
        BigInteger fact2 = 1;
        if (1 < k && n > k && n < 100)
        {
            for (int i = k + 1; i <= n; i++)
            {
                fact1 *= i;
            }
            for (int j = 1; j <= (n - k); j++)
            {
                fact2 *= j;
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
        BigInteger result = fact1 / fact2;
        Console.WriteLine("N! / K!(N-K)! = {0}", result);
    }
}