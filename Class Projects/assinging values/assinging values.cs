using System;
class AssigningValues
{
    static void Main()
    {
        int first_value = 5;
        int second_value = first_value;
        Console.WriteLine("First Value=" + first_value);
        Console.WriteLine("Second Value=" + second_value);
        first_value = second_value = 3;//it will work but avoid this
        Console.WriteLine("First Value=" + first_value);
        Console.WriteLine("Second Value=" + second_value);
    }
}
