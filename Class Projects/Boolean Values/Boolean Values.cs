using System;
class Program
{
    static void Main(string[] args)
    {
        Boolean x;
        int a = 10;
        int b = 20;
        Console.WriteLine("a=" + a);
        Console.WriteLine("b=" + b);
        x = a < b;
        Console.WriteLine("a<b:" + x);
        x = a > b;
        Console.WriteLine("a>b:" + x);
    }
}
