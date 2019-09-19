using System;
class TypesOfInt
{
    static void Main()
    {
        int a = 5;
        Console.WriteLine(a + " is stores in int");
        byte centuries = 20;
        ushort years=2000;
        uint days = 730480;
        ulong hours = 17531520;
        Console.WriteLine("{0} centuries are equal to {1} years, {2} days or {3} hours", centuries, years, days, hours);
    }
}
