using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mubeen_Triangle
{
    class Program
    {
        

static void Main(string[] args)
        {
            Console.Write("Enter 1st side: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd side: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter 3rd side: ");
            int c = int.Parse(Console.ReadLine());
            if (a > b&& a > c)
            {
                Console.WriteLine("1st side is greater");
                int sum=b+c;
                if (sum > a)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

            }

            else if (b > a &&  b > c)
            {
                Console.WriteLine("2nd side is greater");
                int sum = a + c;
                if (sum > a)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
            else
            {
                Console.WriteLine("3rd is greater");
                int sum = a + b;
                if (sum > c)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }
        
    }
}
