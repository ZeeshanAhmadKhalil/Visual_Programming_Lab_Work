using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mubeen_selling_price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sell Price of 15 Items : ");
            int sell_price = int.Parse(Console.ReadLine());
            Console.Write("Enter Earned Profit: ");
            int profit = int.Parse(Console.ReadLine());
            float item_15_price = sell_price - profit;
            float cost_each_item = item_15_price / 15;
            Console.WriteLine("sell_Price: {0} Profit: {1} item_15_price: {2} coast_each_item: {3}", sell_price, profit, item_15_price);
        }
    }
}
