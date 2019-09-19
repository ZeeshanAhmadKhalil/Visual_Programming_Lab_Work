using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter 1 for rectangle are and 2 for triangle area:");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.Write("Enter Height:");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Enter Width:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of Rectangle:" + height * width);
        }
        else if (choice == 2)
        {
            Console.Write("Enter Height:");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Enter Width:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of Triangle:" + 0.5*height * width);
        }
    }
}
