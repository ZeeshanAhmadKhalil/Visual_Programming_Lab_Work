using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Selling Price of 15 items:");
        decimal selling_price = Convert.ToInt32(Console.ReadLine());
        Console.Write("profit Price of 15 items:");
        decimal profit_price = Convert.ToInt32(Console.ReadLine());
        decimal cost_of_15 = selling_price - profit_price;
        decimal cost_of_1 = cost_of_15 / 15;
        Console.WriteLine("Cost of 15:" + cost_of_15);
        Console.WriteLine("Cost of 1:" + cost_of_1);
    }
}