using System;
class Program
{
    static void Main()
    {
        float a = 10.1223f;
        Console.WriteLine(a);
        double b = a;//Implicit Type Casting
        Console.WriteLine(b);
        //float c = b;----------------->It will be wrong as double is too big for float
        float c = (float)b;
        Console.WriteLine(c);
    }
}
