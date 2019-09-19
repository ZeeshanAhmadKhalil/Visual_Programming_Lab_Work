using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = i; j > 0; j--)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}
