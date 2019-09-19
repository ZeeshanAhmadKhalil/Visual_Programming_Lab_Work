using System;

class Program
{
    static void Main()
    {
        Console.Write("C:");
        int C = Convert.ToInt32(Console.ReadLine());
        Console.Write("D:");
        int D = Convert.ToInt32(Console.ReadLine());
        int temp;
        temp = D;
        D = C;
        C = temp;
        Console.WriteLine("C:" + C);
        Console.WriteLine("D:" + D);
    }
}

