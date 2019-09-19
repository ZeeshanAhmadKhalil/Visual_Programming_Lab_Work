using System;
class Program
{
    static void Main()
    {
        int N = 500;
        ulong x, y, z;
        y = x = 1;
        Console.Write(y + "," + x+",");
        for (int i = 1; i <= N-2; i++)
        {
            z = x + y;
            Console.Write(z + ",");
            x = y;
            y = z;
        }
    }
}
