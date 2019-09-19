using System;
class int_string_float_conversions
{
    static void Main()
    {
        
        Console.Write("Enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b:");
        int b = int.Parse(Console.ReadLine());        
        Console.WriteLine("{0}+{1}={2}", a, b, a + b);
        Console.Write("Enter c:");
        float c = float.Parse(Console.ReadLine());
        Console.WriteLine("({0}+{1})*{2}={3}",a,b,c,(a+b)*c);
        Console.WriteLine();
        int i;
        i = Console.Read();
        char ch = (char)i;
        Console.WriteLine("The Ascii of {0} is {1}", ch, i);
        
    }
}