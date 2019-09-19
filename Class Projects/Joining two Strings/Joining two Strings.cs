using System;

class Program
{
    static void Main()
    {
        string first_name;
        string last_name;
        Console.Write("Enter Your Fist Name:");
        first_name = Console.ReadLine();
        Console.Write("Enter Your Last Name:");
        last_name = Console.ReadLine();
        string full_name = first_name + " " + last_name;
        Console.WriteLine("Your Full Name is:" + full_name);
    }
}