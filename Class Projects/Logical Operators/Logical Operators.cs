using System;
class Program
{
    static void Main()
    {
        bool a = true;
        bool b = false;
        Console.WriteLine(a || b);//true
        Console.WriteLine(a && b);//false
        Console.WriteLine(a ^ b);//true
        Console.WriteLine(a ^ !b);//false
        Console.WriteLine(!b);//true
        Console.WriteLine(5<6 ^ (a==b));//true
        Console.WriteLine();
        int c = 5, d = 4;
        Console.WriteLine(c > d);//true
        Console.WriteLine(c < d);//false
        Console.WriteLine(c >= ++d);//true
        Console.WriteLine(c <= d);//true
        Console.WriteLine(c != d);//false
    }
}