using System;

class ArthematicOperators
{
    static void Main()
    {
        int a = 5;
        int b = 4;
        Console.WriteLine(a + b);
        Console.WriteLine(a + b++);
        Console.WriteLine(a + b);
        Console.WriteLine(a + ++b);
        Console.WriteLine();
        int c = 11, d = 3;
        Console.WriteLine(c / d);
        Console.WriteLine(c % d);
        Console.WriteLine();
        int perimeter_of_square = 17;
        double lenth_of_one_side = 17 / 4;
        double area_of_square = Math.Pow(lenth_of_one_side, 2);
        Console.WriteLine("Perimeter Of Square=" + perimeter_of_square);
        Console.WriteLine("Length Of One Side Of Square=" + lenth_of_one_side);
        Console.WriteLine("Area Of Square=" + area_of_square);
    }
}