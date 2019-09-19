using System;
class Program
{
    static void Main()
    {
        var number = 1001;
        var number1 = 1010;
        Console.WriteLine("number="+number);
        Console.WriteLine("number1=" + number1);
        var string_number = number1.ToString();
        Console.WriteLine("String number=" + string_number);
        string_number = String.Format("{0},c",string_number);
        Console.WriteLine("String number=" + string_number);
    }
}