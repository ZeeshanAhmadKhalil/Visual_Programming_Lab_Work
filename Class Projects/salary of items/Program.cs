using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the total selling price:");
        decimal selling_price = int.Parse(Console.ReadLine());
        Console.Write("Enter the total profit earned:");
        decimal profit_price = int.Parse(Console.ReadLine());
        decimal cost_of_15 = selling_price - profit_price;
        decimal cost_of_1 = cost_of_15 / 15;
        Console.WriteLine("Cost of 15 item=" + cost_of_15);
        Console.WriteLine("Cost of 1 item=" + cost_of_1);
    }
}
