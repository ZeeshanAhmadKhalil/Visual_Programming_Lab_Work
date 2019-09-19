using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        while (true)
        {
            Console.Clear();
            Console.Write("Enter Positive Integer:");
            int positive_integer = Convert.ToInt32(Console.ReadLine());
            sum = sum + positive_integer;
            Console.WriteLine("Sum=" + sum);
            Console.Write("Do you want to enter more integers(y/n):");
            char choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'y')
                continue;
            else
                break;
        }
    }
}
