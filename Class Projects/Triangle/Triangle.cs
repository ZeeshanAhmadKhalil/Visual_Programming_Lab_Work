using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Length of sides of Triangle");
        int side1 = int.Parse(Console.ReadLine());
        int side2 = int.Parse(Console.ReadLine());
        int side3 = int.Parse(Console.ReadLine());
        int largest;
        largest=side1;
        if (side1 < side2)
            largest = side2;
        if (side2 < side3)
            largest = side3;
        if (largest == side1)
        {
            if (side2 + side3 > side1)
                Console.WriteLine("valid");
            else
                Console.WriteLine("invalid");
        }
        else if (largest == side2)
        {
            if (side3 + side1 > side2)
                Console.WriteLine("valid");
            else
                Console.WriteLine("invalid");
        }
        else if (largest == side3)
        {
            if (side1 + side2 > side3)
                Console.WriteLine("valid");
            else
                Console.WriteLine("invalid");
        }
    }
}

