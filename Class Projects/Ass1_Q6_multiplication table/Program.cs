﻿using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter Number whose table you want to print:");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0}*{1}={2}", number, i, number * i);
        }
    }
}